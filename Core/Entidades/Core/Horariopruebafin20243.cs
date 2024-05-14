using System;
using System.Collections.Generic;

namespace Core.Entidades.Core;

public partial class Horariopruebafin20243
{
    public string? Profesor { get; set; }

    public string? Materia { get; set; }

    public string? Grupo { get; set; }

    public string? Aula { get; set; }

    public string? CodigoEspaciosFisicos { get; set; }

    public string? Tarea { get; set; }

    public string? Semana { get; set; }

    public string? Codcurso { get; set; }

    public string? Seccion { get; set; }

    public string? Dia { get; set; }

    public int IdDia { get; set; }

    public string? Desde { get; set; }

    public string? Hasta { get; set; }

    public int Orden { get; set; }

    public string CarreraU { get; set; } = null!;

    public string MallaU { get; set; } = null!;

    public string CodCentro { get; set; } = null!;

    public int Nivel { get; set; }

    public string? CodMat { get; set; }

    public int TipoComponente { get; set; }

    public long? Fila { get; set; }

    public string? IdentificacionEmp { get; set; }

    public string? Apellido { get; set; }

    public string? Nombre { get; set; }

    public string? Componente { get; set; }

    public string? Nommateria { get; set; }
}
