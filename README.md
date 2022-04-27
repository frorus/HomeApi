API for a smart home that implements CRUD operations for the entities "Room" and "Device".

Project structure:
* HomeApi  
The API that listens to the port and serves requests. Includes the controllers and the configuration.
* HomeApi.Contracts  
Class library. It contains the request and response models that will be used in the Home Api. Also here is everything related to the validation of these requests and responses.
* HomeApi.Data  
Class library. It contains everything related to data access — table models, repositories, database context.
