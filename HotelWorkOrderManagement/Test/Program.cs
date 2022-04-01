using HotelWorkOrderManagement.Models;

 static void Main(string[] args)
{
    WorkOrderManagementContext context= new WorkOrderManagementContext();
    Console.WriteLine(context.DbPath);

}