add-migration :  Add-Migration InitialModelSetup -Project SchoolManagementSystem.Persistence -StartupProject SchoolManagementSystem.Server -OutputDir Migrations
update-database : Update-Database -Project SchoolManagementSystem.Persistence -StartupProject SchoolManagementSystem.Server
