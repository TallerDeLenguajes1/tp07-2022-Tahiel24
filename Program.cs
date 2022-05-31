//Creando instancias
Random r=new Random();
int aleatorio=r.Next(2,5);
List<Tarea>tareasPendientes=new List<Tarea>();
List<Tarea>tareasRealizadas=new List<Tarea>();

for (int i = 0; i < aleatorio; i++)
{
    Console.WriteLine("Tarea N:"+(i+1));
    int num=i+1;
    Console.WriteLine("Ingrese descripcion de la tarea: ");
    string descrip=Console.ReadLine();
    Random j=new Random();
    int duracion=j.Next(10,100);
    Tarea nuevaTarea=new Tarea(num,descrip,duracion);
    tareasPendientes.Add(nuevaTarea);
}
//Pasaje de tareas pendientes a realizadas 
int desc;
Tarea[]TareasRealizadas=new Tarea[aleatorio];
Console.WriteLine("\n---------------------------\n");
Console.WriteLine("Seleccione su tarea a realizar(1:Si,0:No): ");
foreach (Tarea T in tareasPendientes)
{
    Console.WriteLine("Tarea "+T.TareaID1+": "+T.Descripcion1);
    desc=Convert.ToInt32(Console.ReadLine());
    if(desc==1){
        tareasRealizadas.Add(T);
    }
}

foreach(Tarea T in tareasRealizadas){
    tareasPendientes.Remove(T);
}

Console.WriteLine("\n---------------------------\n");
Console.WriteLine("Tareas pendientes: ");
foreach(Tarea T in tareasPendientes)
{
    Console.WriteLine("Tarea "+T.TareaID1+": "+T.Descripcion1);
}
Console.WriteLine("\nTareas realizadas: ");
foreach(Tarea T in tareasRealizadas)
{
    Console.WriteLine("Tarea "+T.TareaID1+": "+T.Descripcion1);
}

//Busqueda de las tareas por coincidencias
Console.WriteLine("\n\nIngrese la palabra para encontrar coincidencias en tareas pendientes: ");
string busqueda=Console.ReadLine();
bool b=false;

foreach(Tarea T in tareasPendientes){
    b=T.Descripcion1.Contains(busqueda);
    Console.WriteLine("Tarea "+ T.TareaID1);
    if (b)
    {
        Console.WriteLine("\nCoincidencias encontradas");
        Console.WriteLine("Tarea "+T.TareaID1+": "+T.Descripcion1+"\n");

    }else{
        Console.WriteLine("Coincidencias no encontradas\n");
    }
}

