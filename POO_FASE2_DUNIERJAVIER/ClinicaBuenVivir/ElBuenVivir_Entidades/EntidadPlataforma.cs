using System;
using System.Collections.Generic;
using System.Text;

namespace ElBuenVivir_Entidades
{
    public class EntidadPlataforma
    {
        private int plataformaId;
        private int idPaciente;
        private int idCitas;
        private int idFuncionario;
        private TimeSpan horaEntrada;
        private TimeSpan horaSalida;
        private string motivo;
        private string caso;

        public int PlataformaId { get => plataformaId; set => plataformaId = value; }
        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public int IdCitas { get => idCitas; set => idCitas = value; }
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public TimeSpan HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public TimeSpan HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Caso { get => caso; set => caso = value; }

        public EntidadPlataforma(int plataformaId, int idPaciente, int idCitas, int idFuncionario, TimeSpan horaEntrada, TimeSpan horaSalida, string motivo, string caso)
        {
            this.plataformaId = plataformaId;
            this.idPaciente = idPaciente;
            this.idCitas = idCitas;
            this.idFuncionario = idFuncionario;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
            this.motivo = motivo;
            this.caso = caso;
        }

        public EntidadPlataforma()
        {
            plataformaId = 0;
            idPaciente = 0;
            idCitas = 0;
            idFuncionario = 0;
            horaEntrada = TimeSpan.MinValue;
            horaSalida = TimeSpan.MinValue;
            motivo = "";
            caso = "";
        }
    }
}
