# TALA
Identity Server 4 kokeilua
Blazor Webassembly, ASP NET Core hosted, individual user accounts, Identity Server 4
Visual Studio Community 2019 Preview 3.0 tai uudempi
.NET 5 Version 5.0.2 tai uudempi

LocalDB tietokannan luominen:

0. Kloonaa sovellus koneellesi ja avaa se.
1. Klikkaa hiiren oikealla TALA.Server projektia Solution Explorer- ikkunassa ja valitse Manage User Secrets
2. Lisää ikkunassa olevien hakasulkujen sisään

"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=lisaatahanhaluamasinimi;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
  
 3. Voit tietysti käyttää LocalDB: n sijasta omaa SQL Server instanssia tai vaikka Azure SQL: ää. UserSecrets.json kansio on sovelluksen ulkopuolella 
    joten mikään ei pushaannu sieltä Githubiin.
   
 4. Avaa Package Manager Console ikkuna yläpalkista View -> Other Windows -> Package Manager Console
 5. Kirjoita PM> Update-Database ja iske Enter jolloin TALA.Server.Data.Migrations kansiossa olevat scriptit ajetaan. Ne luovat tarvittavan tietokannan.
 6. Tarkastele luotua LocalDB kantaa avaamalla yläpalkista View -> SQL Server Object Explorer ja valitse nimeämäsi.
 7. Aja sovellus ja kokeile.
    
