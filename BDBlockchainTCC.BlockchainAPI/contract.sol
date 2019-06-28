pragma solidity >=0.5.1 <0.7.0;



contract BlockchainToBD {
    struct Data {
        bytes32 hash;
        bool deleted;
    }
    struct Table {
        uint128 numData;
        mapping(uint128 => Data) data;
    }
    
    struct DB {
        mapping(uint64 => bool) tablesInDB;
        bytes32 ipAdd;
    }
    
    uint64 numTables;
    mapping(uint64 => Table) tables;
    
    uint32 numDB;
    mapping(uint32 => DB) dbs;
    mapping(address => uint32) dbsAddr;
    
    function verify(uint64 tId, uint128 dId, bytes32 hash) public view returns (bool check) {
        return tables[tId].data[dId].hash == hash && !tables[tId].data[dId].deleted;
    }
    
    event DataModified (
        uint64 indexed tId,
        uint128 dId,
        address sender,
        bytes32 prevHash,
        bytes32 nextHash
    );
    
    event tableAdded(
        uint64 indexed tId,
        address sender
    );
    
    event tableAddedToDB(
        uint64 indexed tId,
        address sender
    );
    
    event getItem (uint64 indexed tId, uint128 dId,address sender);
    
    function addData(uint64 tId, bytes32 dataToHash) public returns (bytes32 hash, uint128 Id) {
        bytes32 hashGen = sha256(abi.encode(dataToHash, now));
        uint128 dId = tables[tId].numData++;
        bytes32 prev = tables[tId].data[dId].hash;
        tables[tId].data[dId].hash = hashGen;
        tables[tId].data[dId].deleted = false;
        emit DataModified(tId, dId, msg.sender, prev, hashGen);
        return (hashGen, dId);
    }
    
    function updateData(uint64 tId, uint128 dId, bytes32 dataToHash, bytes32 prevHash) public returns (bytes32 hash) {
        if (prevHash == tables[tId].data[dId].hash && !tables[tId].data[dId].deleted) {
            bytes32 hashGen = sha256(abi.encode(dataToHash, now));
            tables[tId].data[dId].hash = hashGen;
            emit DataModified(tId, dId, msg.sender, prevHash, hashGen);
            return hashGen;
        }
        return prevHash;
    }
    
    function deleteData(uint64 tId, uint128 dId, bytes32 prevHash) public returns (bool deleted) {
        if (prevHash == tables[tId].data[dId].hash) {
            tables[tId].data[dId].deleted = true;
        }
        return tables[tId].data[dId].deleted;
    }
    
    function addTable() public returns (uint64 id) {
        uint64 num = numTables;
        numTables++;
        dbs[dbsAddr[msg.sender]].tablesInDB[num] = true;
        emit tableAdded(num, msg.sender);
        emit tableAddedToDB(num, msg.sender);
        return num;
    }
    
    function addTableToDB(uint64 tId) public {
        dbs[dbsAddr[msg.sender]].tablesInDB[tId] = true;
        emit tableAddedToDB(tId, msg.sender);
    }
    
    function getCallForItem(uint64 tId, uint128 dId) public returns (bytes32 hash) {
        Data memory data = tables[tId].data[dId];
        if (!data.deleted){
            emit getItem(tId, dId, msg.sender);
            return data.hash;
        }
        return 0;
    }
    
    
    function addDB(bytes32 IPAddress) public {
        dbsAddr[msg.sender] = numDB;
        dbs[numDB].ipAdd = IPAddress;
        numDB++;
    }
    
    function getIPAddr(address locate) public view returns (bytes32 ip) {
        return dbs[dbsAddr[locate]].ipAdd;
    }
}