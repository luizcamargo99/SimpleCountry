# SimpleCountry

Nuget Package intended for accessing country information, containing 250 countries.

## Download

- Package Manager

```
NuGet\Install-Package SimpleCountry -Version 1.0.2
```

- .NET CLI

```
dotnet add package SimpleCountry --version 1.0.2
```



## Usage

- Get All Countries

```cs
ICountryService countryService = new CountryService();
var countries = countryService.GetAll();
```

![image](https://user-images.githubusercontent.com/59785233/203529909-765db161-4be8-45a3-bd59-a8a44a2c025b.png)


- Get By Code (Alpha 2 or Alpha 3)

```cs
ICountryService countryService = new CountryService();
var brazil = countryService.GetByCode("BR");
```

![image](https://user-images.githubusercontent.com/59785233/203529672-27415999-ddac-4f15-bedb-8d4159d4ca3b.png)

- Get By Name

```cs
ICountryService countryService = new CountryService();
var spain = countryService.GetByName("Spain");
```

![image](https://user-images.githubusercontent.com/59785233/203530111-b18d4b83-8202-4e35-899c-7d1c4888fd49.png)

