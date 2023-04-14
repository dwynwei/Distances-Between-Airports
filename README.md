# Airport Distance API

This project is a .NET 5.0 backend API that provides the distance between airports in kilometers as a JSON result. The API is documented using Swagger.

## Installation

1. Clone this repository.
2. Open the solution file (`DistanceAPI.sln`) in Visual Studio or any other compatible IDE.
3. Build the solution to restore NuGet packages.
4. Build the solution again to compile the project.

## Usage

1. Run the project.
2. Navigate to `https://localhost:[port]/swagger` in your web browser to view the Swagger documentation.
3. Test the API by clicking on the `GET /airports`, `GET /airport/{iataCode}`, `GET /distance/from={from}&to={to}` endpoint and clicking on the `Try it out` button.
4. Enter the 3-letter IATA codes for the departure and arrival airports in the `DepartureAirport` and `ArrivalAirport` parameters, respectively.
5. Click on the `Execute` button to send the request.
6. The distance between the airports in kilometers will be returned in the `Response Body` section.

## Contributing

Contributions to the project are welcome! Please open a pull request with your changes.

## License

This project is licensed under the MIT License. See the `LICENSE.md` file for details.
