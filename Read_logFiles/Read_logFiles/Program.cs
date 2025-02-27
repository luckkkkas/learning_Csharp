
using Read_logFiles.Entities;

Console.Write("Insira o camingo do arquivo de Log:");
string logPath = Console.ReadLine();
HashSet<LogRecord> list = new HashSet<LogRecord>();

try {
    using (StreamReader sr = File.OpenText(logPath)) {
        while (!sr.EndOfStream) {
            string line = sr.ReadLine();
            string[] rows = line.Split(' ');
            DateTime instant = DateTime.Parse(rows[1]);
            list.Add(new LogRecord(rows[0].ToString(), instant));
        }
        Console.WriteLine($"{list.Count()} usuários Acessaram o site;");
    }
} catch (IOException err) {
    Console.WriteLine(err.Message);
}