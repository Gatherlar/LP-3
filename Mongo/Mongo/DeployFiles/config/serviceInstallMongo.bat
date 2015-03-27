cd "C:\Program Files\MongoDB\Server\3.0\bin" 
mongod -f "C:\GitHub\Survivor\SL\DeployFiles\Config\mongodb.conf" -install -serviceName mongoDB27017 -serviceDisplayName "MongoDB Server Instance port 27017" -serviceDescription "MongoDB Server Instance running on 27017"

pause