## API
> [!NOTE]
> ASP.NET Core Web API <sub>w/ <b>Swagger</b></sub>  
> SQL Server  
> Project: [CryptoFinder](https://github.com/FabiomtGoncalves/CryptoFinder)  

| REQUEST | API URL                                 | DESC   |
|  :---:  |:---------------------------------------:|:-------:|
| GET     | https://localhost:7290/api/Crypto/ping  | Ping, to know if the connection is success.                        |
| GET     | https://localhost:7290/api/Crypto/all   | A list with every crypto in the db.                                |
| GET     | https://localhost:7290/api/Crypto/{id}  | Get a specific crypto by id.                                       |
| POST    | https://localhost:7290/api/Crypto       | Create a crypto by specifying the correct info in each parameter.  |
| PUT     | https://localhost:7290/api/Crypto       | Update info about an existing crypto.                              |
| DELETE  | https://localhost:7290/api/Crypto       | Delete an existing crypto by id.                                   |
