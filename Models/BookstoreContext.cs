using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission11.Models;

public partial class BookstoreContext : DbContext
{

    public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) { }

    public virtual DbSet<Book> Books { get; set; }
}
