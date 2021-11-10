# _Animal Shelter_

#### _This api is for an animal shelter database of animals_

#### _**By Diego Serafico**_

## Technologies Used

* _C#_
* _.NET 5_

## Description

_This api is for an animal shelter to access a database of the different animals they have there. You can get a list of all the animals, or filter them by animalId, species, age, etc. In addition you can add, edit, patch, and delete animals from the database. It implements swagger for an easy way to see the endpoints, as well as CORS for use with programs from other languages. Follow instructions below to see how you can access these._

Further exploration includes swagger documentation, enabling and testing CORS, and a PATCH API that allows users to update the database by sending only partial feilds.

### Technology Requirements

* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)

## Setup/Installation Requirements

* _Clone this repository to your desktop_
* _Open in text editor_
* _Create appsettings.json in /AnimalShelter.Solution/AnimalShelter directory_
* _Copy this code into appsettings.json, replacing YOUR_PASSWORD with your MySQL password:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=diego_serafico;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* _open new terminal and run SQL ($ mysql -uroot -p{your_password})_
* _open MySQL Workbench_
* _In the Navigator > Administration window, select Data Import/Restore.
* _In Import Options select Import from Self-Contained File_
* _Navigate to diego_serafico.sql located on the root directory of the project_
* _Under Default Schema to be Imported To, select the New button & Enter diego_serafico as name of database_
* _Click Ok_
* _Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window_
* _After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. The diego_serafico database should appear._
* _In terminal, navigate into AnimalShelter.Solution/AnimalShelter/ and enter the command $ dotnet restore, to install necessary packages_
* _enter command $ dotnet build, to build program_
* _enter command $ dotnet run, to view program in your browser_
* _press ctrl or cmd and click on the localhost link_
* _type in the endpoints to see the results of animals **Example:** localhost:5004/api/Destinations/?age=5 to see the animals of age 5._

**_To make updates to the database you'll need to use postman. Follow these instructions for use in postman_**
* _download postman [Here](https://www.postman.com/downloads/)_
* _type in the localhost link from the dotnet run command **Example:** http://localhost:5000/api/Animals/ to see the list of animals in json organized by the animalId. Make sure this is set to the get endpoint to the left of the link bar if you want to see results. You can see one animal by adding a number to the end of that link. You'll see the animal that corresponds to that id._
* _To filter and see specific animals you can add different paths to the end of the link **Example:** http://localhost:5000/api/Animals/?species=mouse to see the mice at the shelter. You can filter by name, species, gender, and age._
* _To add animals simply change the endpoint from get to post with no paths on the link._
* _To delete animals use the delete endpoint._
* _To edit animals there are two options. Both need the specific id for the animal added to the url, and navigating to the body tab under the link, choosing raw from the options and json for the language result. The first option is the PUT endpoint where you give all of the fields of the animal in, even if you're not changing them. The second is PATCH where you only have to give the fields that your changing._
* _In order to use patch call the api http://localhost:5000/api/Animals/id with PATCH, and a json body with format shown below. You can use patch to modify the animal in several ways by adding, replacing, and removing feilds. For example the following request would update animal with ID 1 to have age 7._
PATCH http://localhost:5000/api/Animals/1
Body:
```
[
  {
    "op": "replace", "path": "/age", "value" : "7"
  }
]
```
* _CORS allows callers to call the API from another domain. You can test CORS using CURL as follows_
```

curl -H "Origin: http://google.com" --verbose http://localhost:5000/api/animals

```
* _Swagger displays the available endpoints. You can view it by running:_
dotnet watch run
_then going to http://localhost:5000 in your broswer_

## Known Bugs

* _NA_

## License

_[GPL](https://opensource.org/licenses/gpl-license)_

## Contact Information
  
Diego Serafico: <dseraficohernandez@gmail.com> 🍃