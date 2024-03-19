using Microsoft.EntityFrameworkCore;
using Task1;
namespace Task2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using MyDatabase db = new MyDatabase();
            string request = "try to get negative index";
            try
            {
                var order = db.Orders.ToArray()[-1];
                await Console.Out.WriteLineAsync(order.ToString());
                db.Errors.Add(new Error(DateTime.Now, StatusCode.Ok));
            }
            catch (DbUpdateConcurrencyException ex)
            {
                db.Errors.Add(new Error(ex.Message, DateTime.Now, StatusCode.Server, request));
            }
            catch (DbUpdateException ex)
            {
                db.Errors.Add(new Error(ex.Message, DateTime.Now, StatusCode.Server, request));
            }
            catch (ObjectDisposedException ex)
            {
                db.Errors.Add(new Error(ex.Message, DateTime.Now, StatusCode.NotFound, request));
            }
            catch (InvalidOperationException ex)
            {
                db.Errors.Add(new Error(ex.Message, DateTime.Now, StatusCode.NotFound, request));
            }
            catch (OperationCanceledException ex)
            {
                db.Errors.Add(new Error(ex.Message, DateTime.Now, StatusCode.NotFound, request));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                db.Errors.Add(new Error(ex.Message, DateTime.Now, StatusCode.NotFound, request));
            }
            catch (Exception ex)
            {
                db.Errors.Add(new Error(ex.Message, DateTime.Now, StatusCode.NotFound, request));
            }
            await Console.Out.WriteLineAsync("Done!");
            foreach(var error in db.Errors)
            {
                await Console.Out.WriteLineAsync($"Message: {error.Message}; \nTime: {error.Time}; \n Status code: {error.Status}; \n Request: {error.Request}.");
            }
        }
    }
}
