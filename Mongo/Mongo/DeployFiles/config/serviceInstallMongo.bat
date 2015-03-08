cd "C:\Program Files\MongoDB 2.6 Standard\bin\"
mongod -f "C:\GitHub\Survivor\SL\DeployFiles\Config\mongodb.conf" -install -serviceName mdb27017 -serviceDisplayName "MongoDB Server Instance 27017" -serviceDescription "MongoDB Server Instance running on 27017"

pause