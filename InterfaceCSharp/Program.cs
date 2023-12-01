using InterfaceCSharp;

SomeFile file = new();
file.WriteTextFile(); // của textfile
file.WriteBinaryFile(); //  của ibinaryfile
file.ReadFile(); // common vì cả 2 đều có
((IBinaryFile)file).ReadFile(); // của IBanaryfile, old C#

(file as ITextFile).ReadFile(); // của ITextFile, new C#

AnyFile anyFile = new();
anyFile.WriteTextFile();
anyFile.WriteBinaryFile();
(anyFile as ITextFile).ReadFile();
(anyFile as IBinaryFile).ReadFile();
(anyFile as IBinaryFile).ShowInfo();
