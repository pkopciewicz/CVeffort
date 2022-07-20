After pulling from FinishedOfflineVersion there are few things to edit locally to make it work.

--------------------------------------------------------------------------------------------------------------------------------------------

1) Change databese connection string in CVeffort/appsettings.json:

Replace:

"DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-CVeffort-901AA4DD-AADA-4CB5-AA3E-E11F04D3C51D;Trusted_Connection=True;MultipleActiveResultSets=true"
 
with a connection string to the database you have access to.
 
--------------------------------------------------------------------------------------------------------------------------------------------
 
2) Add e-mail verification with SendGrid or skip that step to resign from e-mail verification.
------------- 
2.a) To skip:

Change in CVeffort/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml.cs:

DisplayConfirmAccountLink = false;

to be true (it is line 45)
-------------
2.b) To add e-mail verification:
