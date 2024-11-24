# Infigo_Catalin_Plesu 

## To launch database
> docker-compose up

## To launch app
> docker run --network host -it -v $(pwd):/app mcr.microsoft.com/dotnet/sdk:7.0 bash

## Add migration
> dotnet ef --startup-project ../CMSPlus.Presentation migrations add v1_1_2__Create_Comment_Table

## Apply migration
> dotnet ef database update --startup-project ../CMSPlus.Presentation
