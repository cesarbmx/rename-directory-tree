using System;
using System.IO;
using RenameSubFolderAndFiles.Models;

namespace RenameSubFolderAndFiles.Services
{
    public class ArguementsConverter
    {
        public ArguementsConverter(string[] args)
        {
            args = new[] { @"C:\cesarc\GitHub\Shared", "Pinnacle.CustomerTeam", "CesarBmx" };

            if (args.Length != 3)
                throw new ArgumentException("3 args need to be supplied");

            ArguementsModel = new ArguementsModel
            {
                Path = args[0],
                ChangeFrom = args[1],
                ChangeTo = args[2]
            };

            if(!Directory.Exists(ArguementsModel.Path))
                throw new ArgumentException("Path does not exist.");
        }

        public ArguementsModel ArguementsModel { get; }
    }
}