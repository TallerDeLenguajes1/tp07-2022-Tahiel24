public class Tarea{
    //Variables
    private int TareaID;
    string Descripcion;
    private int Duracion;

    //Propiedades
    public int TareaID1 { get => TareaID; set => TareaID = value; }
    public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
    public int Duracion1 { get => Duracion; set => Duracion = value; }

    //Constructora    
    public Tarea(int num, string texto,int dur){
        TareaID1=num;
        Descripcion1=texto;
        Duracion1=dur;
    }

    //Metodos
}