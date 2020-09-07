## Git (in opbouw)

In dit hoofdstuk geven we een summier overzicht over git. Bedoeling is dat je git kan gebruiken om versiebeheer van eigen **lokale** projecten te hebben. Met andere woorden, het zal je er toe in staat stellen om een historiek van je project(en) te hebben.

Een [goede uitleg vind je hier](https://www.sitepoint.com/git-for-beginners/).

### File lifecycle
  ![file lifecycle](../assets/b_git/filelife.png)

### Belangrijkste commando's

* ``git init``: in de huidige folder een git repository aanmaken (een verborgen ``.git`` folder) waarin vanaf nu alle te volgen veranderingen zullen bewaard worden. Indien je deze hoofdfolder verplaatst (inclusief de ``.git`` folder) dan zal deze repository mee verhuizen.
* ``git add``
  * Bij bestanden en folder die je nog niet volgde: vanaf nu zullen veranderingen in dit bestand of folder door git gevolgd worden
  * Bij reeds gevolgde bestanden: de veranderingen in dit bestand zullen bij de eerstvolgende commit toegevoegd worden.

* ``git commit``: alle te volgen veranderingen (via ``add``) worden naar een commit geschreven. Je maakt als het ware een snapshot van de huidige staat van je gevolgde bestanden.   ![Verschil git add en git commit](../assets/b_git/addcommit.png)
* ``git status``: kijk hoe je repo er voor staat. Zijn er veranderingen die je nog niet hebt gecommit, etc?

![Alles samen](../assets/b_git/alltoget.png)


<!---NOBOOKSTART--->
# Kennisclip
![](../assets/infoclip.png)

* [Workshop](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=e792a44a-98ee-43d4-a466-ab5d00900024)
* [Kennisclip 1](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=8d1f333b-8f7d-4104-b64f-ab5d00acbae7)  Hoe in Visual Studio een repo aanmaken in bestaand project en commits doen
* [Kennisclip 2](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=fd78d6a1-0a85-437b-a76a-ab5d00ad8ac0) Hoe in gitkraken commits doen en basic werking
* [Kennisclip 3](https://ap.cloud.panopto.eu/Panopto/Pages/Viewer.aspx?id=34e78069-e1fe-4e08-801b-ab5d00b05f46) Hoe in gitkraken een bestaand prpject naar een nieuwe github repo pushen en vervolgens tonen hoe dit ook in VS dan kan gebeuren
<!---NOBOOKEND--->