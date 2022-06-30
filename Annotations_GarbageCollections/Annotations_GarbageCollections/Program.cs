// See https://aka.ms/new-console-template for more information
using Annotations_GarbageCollections;
using static Annotations_GarbageCollections.Garbage_Collections;

Console.WriteLine("Welcome to Annotation ANd GarbageCollection Demo Project");


Console.WriteLine("1 - To Run Annotations\n2 - To Run Garbage Collections");
int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        {
            NewAtteribute.printAtteributes(typeof(Annotations_GarbageCollections.Students));
            Console.WriteLine();
            NewAtteribute.printAtteributes(typeof(Annotations_GarbageCollections.Teachers));
            Console.WriteLine();
            break;
        }
    case 2:
        {
            DisposableResourceHolder disposableResourceHolder = new DisposableResourceHolder();
            disposableResourceHolder.Dispose();
            Annotations_GarbageCollections.Garbage_Collections Gc = new Annotations_GarbageCollections.Garbage_Collections();
            Gc.Collector();
            break;
        }
}