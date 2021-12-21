// See https://aka.ms/new-console-template for more information


using SaladeChat;
{
    IMediator mediator = new Mediator ("Grupo Ejemplo de Mediator");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Grupo '{mediator.NombredelGrupo()}' Creado!");

    Usuarios Luis = new CConcretaUsuarios(mediator, "Luis");
    Usuarios Andrea = new CConcretaUsuarios(mediator, "Andrea");
    Usuarios Martha = new CConcretaUsuarios(mediator, "Martha");

    mediator.RegistrodeUsuarios(Luis);
    mediator.RegistrodeUsuarios(Andrea);
    mediator.RegistrodeUsuarios(Martha);

    Andrea.EnviarMensaje("Hola compañeros");
    Martha.EnviarMensaje("Me agrada este grupo");
    Luis.EnviarMensaje("Hola Andrea y Martha");

    mediator.AnularRegistrodeUsuario(Martha);

    Andrea.EnviarMensaje("¿Qué ha pasado?");

    mediator.RegistrodeUsuarios(Martha);

    Martha.EnviarMensaje("Lo siento chicos, tuve un problema");
    Andrea.EnviarMensaje("¡Oh, genial!");

    Console.ResetColor();
    Console.WriteLine("\nPresione cualquier tecla para cerrar\n");
    Console.ReadKey();

}
