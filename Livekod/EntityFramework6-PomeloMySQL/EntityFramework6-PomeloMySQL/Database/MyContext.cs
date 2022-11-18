namespace EntityFramework6_PomeloMySQL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Models;

public class MyContext : DbContext
{
    public DbSet<Cat> Cats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Read string from my documents
        // path = Mina dokuments mappen
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        // Läs filen connstring.txt från mappen och spara i en string
        string connstring = File.ReadAllLines(path + "\\connstring.txt")[0];

        //"server=(server);user=(du);password=(password);database=(database)";

        // Pomelo lösning
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
        optionsBuilder.UseMySql(connstring, serverVersion);
    }

}
