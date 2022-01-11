using AgenziaViaggiFluentAPI;

using (var ctx = new Context())
{
    //tramite la variabile ctx richiamo il metodo ens.. che crea un db se non esiste
    ctx.Database.EnsureCreated();
}