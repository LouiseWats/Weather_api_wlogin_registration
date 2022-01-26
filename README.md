# Weather_api_wlogin_registration

I decided to make a desktop app in Visual Studio with the use of C#.
It includes a splash form with a rotating progressbar, a login and registration form, and a form that shows weather data.


- C# .NET
- Microsoft Jet Database, OLE DB
- OpenWeather API


More info about [Microsoft Jet Database Engine](https://docs.microsoft.com/en-us/sql/ado/guide/appendixes/microsoft-ole-db-provider-for-microsoft-jet?view=sql-server-ver15).
- Create the database by using Microsoft Access.
- Create a table that contains a username and a password field.
- Go to View > Datasheet View
- Create credentials for admin
- Save as .mdb in the bin/debug folder of your project.
- Then call the OLE DB namespace: *using System.Data.OleDB;*
- Look under *Registration* for the source code


OpenWeather Api [here](https://openweathermap.org/)
- Create an account on OpenWeather
- Genereate an api key under [profile name] > My API keys
- I have converted the temperature to Celcius, but remove the method if you want to use Kelvin. The default temperature from OpenWeather is Kelvin. 


![Splash Screen](https://i.imgur.com/ElHPdsI.png)

![Login](https://i.imgur.com/wHMdKil.png) ![Registration](https://i.imgur.com/yzWitZo.png)

![Weather Searching](https://i.imgur.com/3EEuaZS.png)
