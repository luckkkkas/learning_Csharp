using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Read_logFiles.Entities {
    internal class LogRecord {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string username, DateTime instant) {
            Username = username;
            Instant = instant;
        }

        public override bool Equals(object? obj) {
            if (!(obj is LogRecord)) return false;

            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }

        public override int GetHashCode() {
            return Username.GetHashCode();
        }
    }
}
