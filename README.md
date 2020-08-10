# 3Cols API

Lightweight library supporting all available objects and endpoints used by the 3Cols API. For more information see our [docs](https://3cols.com/docs)

### Getting your API key

  - Sign into [3Cols](https://3cols.com) 
  - Navigate to your [account page](https://3cols.com/account)
  - Click the green enable button under the API heading
  - Use the blue eye button to reveal your API key

### Usage
Create a new APIClient with the following syntax
```cs
var apiClient = new ThreeColsClient("myAPIKey"); 
```
It's up to you to manage the security of your API key.

To use your new client, it's a simple as
```cs
var myBoards = apiClient.ListBoards();
```
Note all methods are asynchronous. For a full list of all the endpoints and their parameters, please visit the [docs](https://3cols.com/docs).

### Objects
All response and request objects are available in the ThreeCols.Objects namespace.
