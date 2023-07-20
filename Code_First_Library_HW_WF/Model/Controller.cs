using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RelationshipEF_LoadingDb_18._07_WF.Model
{
    class Controller
    {
        public LibraryContext libraryContext;
        public Controller() { }



        public void IniBase()
        {
            using (libraryContext = new LibraryContext())
            {
                ProductionHouse phGeorgeAllen_Unwin = new ProductionHouse { Name = "George Allen & Unwin" };
                ProductionHouse phAST = new ProductionHouse { Name = "ACT" };
                ProductionHouse bhMethuen = new ProductionHouse { Name = "Methuen Publishing" };


                Category cTFantasy = new Category { Name = "Фэнтези" };
                Category cTNovel = new Category { Name = "Роман" };
                Category cTDetective = new Category { Name = "Дэтектив" };

                Author athTolkin = new Author { Name = "Дж.Р.Р.Толкин" };
                Author athOstine = new Author { Name = "Джейн Остин" };
                Author athMiln = new Author { Name = "Алан Милн" };

                Book bkFellowshipRing = new Book
                {
                    Name = "Властелин Колец",
                    AmountPages = 600,
                    Category = cTFantasy,
                    Author = athTolkin,
                    ProductionHouse = phGeorgeAllen_Unwin
                };
                Book bkPrideAndPrejudice = new Book
                {
                    Name = "Гордость и предубеждение",
                    AmountPages = 540,
                    Category = cTNovel,
                    Author = athOstine,
                    ProductionHouse = phAST
                };
                Book bkWinnieThePooh = new Book
                {
                    Name = "Винни Пух",
                    AmountPages = 600,
                    Category = cTNovel,
                    Author = athMiln,
                    ProductionHouse = bhMethuen
                };
                Book bkMrPim = new Book
                {
                    Name = "Мистер Пим",
                    AmountPages = 380,
                    Category = cTNovel,
                    Author = athMiln,
                    ProductionHouse = bhMethuen
                };
                Book bkLeafbyNiggle = new Book
                {
                    Name = "Лист кисти Ниггля",
                    AmountPages = 490,
                    Category = cTDetective,
                    Author = athTolkin,
                    ProductionHouse = phAST
                };


                libraryContext.ProductionHouse.AddRange(new List<ProductionHouse> { phAST, phGeorgeAllen_Unwin, bhMethuen });
                libraryContext.Categories.AddRange(new List<Category> { cTFantasy, cTNovel, cTDetective });
                libraryContext.Authors.AddRange(new List<Author> { athTolkin, athOstine, athMiln });
                libraryContext.Books.AddRange(new List<Book> { bkFellowshipRing, bkPrideAndPrejudice, bkWinnieThePooh, bkMrPim, bkLeafbyNiggle });
                libraryContext.SaveChanges();


            }

        }
        public DbSet<Book> GetBooks()
        {
            return libraryContext.Books;
        }

        public DbSet<Author> GetAuthors()
        {
            using (libraryContext = new LibraryContext())
            {
                return libraryContext.Authors;
            }

        }
        public DbSet<Category> GetCategory()
        {
            using (libraryContext = new LibraryContext())
            {
                return libraryContext.Categories;
            }

        }

        public DbSet<ProductionHouse> GetProductionHouse()
        {
            using (libraryContext = new LibraryContext())
            {
                return libraryContext.ProductionHouse;
            }

        }
        public void AddBook(string name, int pages, string category, string author, string productionHouse)
        {
            using (libraryContext = new LibraryContext())
            {
                Author author1 = null;
                Category category1 = null;
                ProductionHouse productionHouse1 = null;
                foreach (var el in libraryContext.Books.Include("Author"))
                {
                    if (el.Author.Name == author)
                        author1 = el.Author;
                    else author1 = new Author() { Name = author };
                }

                foreach (var el in libraryContext.Books.Include("Category"))
                {
                    if (el.Category.Name == category)
                        category1 = el.Category;
                    else category1 = new Category() { Name = category };
                }
                foreach (var el in libraryContext.Books.Include("ProductionHouse"))
                {
                    if (el.ProductionHouse.Name == productionHouse)
                        productionHouse1 = el.ProductionHouse;
                    else productionHouse1 = new ProductionHouse() { Name = productionHouse };
                }


                Book book = new Book() { Name = name, AmountPages = pages, Category = category1,
                    Author = author1, ProductionHouse = productionHouse1 };

                libraryContext.Books.Add(book);
                libraryContext.SaveChanges();
            }
        }

        public void DelBook(int ID)
        {
            using (libraryContext = new LibraryContext())
            {
                Book book = libraryContext.Books.Where(x => x.Id == ID).FirstOrDefault();
                libraryContext.Books.Remove(book);
                libraryContext.SaveChanges();

            }
        }


        public void ChangeBook(Book bk)
        {
            using (libraryContext = new LibraryContext())
            {
                Book book = libraryContext.Books.Where(x => x.Id == bk.Id).FirstOrDefault();
                book.Name = bk.Name;
                book.Author = bk.Author;
                book.AmountPages = bk.AmountPages;
                book.Category = bk.Category;
                book.ProductionHouse = bk.ProductionHouse;
                libraryContext.SaveChanges();

            }
        }

        public Collection<Book> SearchBookByName(string nameBook)
        {
            Collection<Book> bk = new Collection<Book>();
            using (libraryContext = new LibraryContext())
            {
                
                foreach (var  book in libraryContext.Books)
                {
                    if (book.Name == nameBook)
                                 bk.Add(book);
                }
            }
            return bk;

        }

        public Collection<Book> SearchBookByAuthor(string nameAuthor)
        {
            Collection<Book> bk = new Collection<Book>();
            using (libraryContext = new LibraryContext())
            {
                foreach (var book in libraryContext.Books.Include("Author"))
                {
                   if(book.Author.Name == nameAuthor)
                        bk.Add(book);
                }
            }
            return bk;
        }


        public Collection<Book> SearchBookByCategory(string nameCategory)
        {
            Collection<Book> bk = new Collection<Book>();
            using (libraryContext = new LibraryContext())
            {
                foreach (var book in libraryContext.Books.Include("Category"))
                {
                    if (book.Category.Name == nameCategory)
                        bk.Add(book);
                }
            }
            return bk;
        }


        public Collection<Book> SearchBookByPublishHouse(string namePublishHouse)
        {
            Collection<Book> bk = new Collection<Book>();
            using (libraryContext = new LibraryContext())
            {
                foreach (var book in libraryContext.Books.Include("ProductionHouse"))
                {
                    if (book.ProductionHouse.Name == namePublishHouse)
                        bk.Add(book);

                }
            }

            return bk;
        }

    }
}
