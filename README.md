# API WEB

## Description

This project is an exciting API Web application built using ASP.NET controllers and CRUD operations. It provides a seamless experience for managing and interacting with pizza data.

## Technologies Used

- C# 
- ASP.NET Core
- Visual Studio Code

## Installation

To install the project, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in your preferred IDE.
3. Restore the NuGet packages by running the command `dotnet restore` in the terminal.
4. Build the project by running the command `dotnet build` in the terminal.
5. Start the API by running the command `dotnet run` in the terminal.

Once the API is running, you can interact with it using the provided API documentation.

## API Documentation

### Endpoints

#### Get All Pizzas

- **URL:** `/api/v1/pizza`
- **Method:** GET
- **Description:** Retrieves all pizzas from the database.
- **Response:** JSON array of pizza objects.

#### Get Pizza by ID

- **URL:** `/api/v1/pizza/{id}`
- **Method:** GET
- **Description:** Retrieves a specific pizza by its ID.
- **Parameters:**
    - `id` (path parameter): The ID of the pizza.
- **Response:** JSON object representing the pizza.

#### Create Pizza

- **URL:** `/api/v1/pizza`
- **Method:** POST
- **Description:** Creates a new pizza.
- **Request Body:** JSON object representing the pizza to be created.
- **Response:** JSON object representing the created pizza.

#### Update Pizza

- **URL:** `/api/v1/pizza/{id}`
- **Method:** PUT
- **Description:** Updates an existing pizza.
- **Parameters:**
    - `id` (path parameter): The ID of the pizza to be updated.
- **Request Body:** JSON object representing the updated pizza.
- **Response:** JSON object representing the updated pizza.

#### Delete Pizza

- **URL:** `/api/v1/pizza/{id}`
- **Method:** DELETE
- **Description:** Deletes a specific pizza by its ID.
- **Parameters:**
    - `id` (path parameter): The ID of the pizza to be deleted.
- **Response:** No content.

### Error Handling

- **Status Code 404:** If a pizza with the specified ID is not found.
- **Status Code 400:** If the request body is invalid or missing required fields.

### Authentication and Authorization

- This API does not require authentication or authorization.

### Sample Requests and Responses

#### Get All Pizzas

**Request:** GET `/api/v1/pizza`

**Response:**

```json
[
    {
        "id": 1,
        "Name": "Margherita",
        "IsGlutenFree": true
    },
    {
        "id": 2,
        "Name": "Pepperoni",
        "IsGlutenFree": false
    }
]
```

#### Get Pizza by ID

**Request:** GET `/api/v1/pizza/1`

**Response:**

```json
{
    "id": 1,
    "Name": "Margherita",
    "IsGlutenFree": true
}
```

#### Create Pizza

**Request:** POST `/api/v1/pizza`

**Request Body:**

```json
{
    "Name": "Hawaiian",
    "IsGlutenFree": true
}
```

**Response:**

```json
{
    "id": 3,
    "Name": "Hawaiian",
    "IsGlutenFree": true
}
```

#### Update Pizza

**Request:** PUT `/api/v1/pizza/3`

**Request Body:**

```json
{
    "Name": "Hawaiian Deluxe",
    "IsGlutenFree": true
}
```

**Response:**

```json
{
    "id": 3,
    "Name": "Hawaiian Deluxe",
    "IsGlutenFree": false
}
```

#### Delete Pizza

**Request:** DELETE `/api/v1/pizza/3`

**Response:** No content.


## Contributing

I appreciate all contributions! This project is intended for study purposes only, using the [Microsoft Learn](https://learn.microsoft.com/pt-br/training/) platform.


