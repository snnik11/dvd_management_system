using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DS
{
    class Program
    {

        public static Borrower getBorrower()
        {
            Write("\nMay I know your first name please? ");
            string firstName = ReadLine();
            Write("May I know your last name please? ");
            string lastName = ReadLine();
            Write("Enter your contact no: ");
            string contact;

            while (true)
            {
                contact = ReadLine();
                if (contact != null && contact.Length == 10) //to avoid null point exception
                {
                    WriteLine("Thankyou for your details");
                    break;
                }
                else
                {
                    WriteLine("Please provide a ten digit number");
                    Write("Enter your contact no again: ");                
                }
            }     
            return new Borrower(firstName, lastName, contact);
        }

        public static Staff getStaff()
        {
            Write("\nMay I know your name please? ");
            string firstName = ReadLine();
            return new Staff(firstName);
        }

        static void Main(string[] args)
        {

            WriteLine("***_***_***_***_***_***_***_***_***_***_***");
            WriteLine("*                                         *");
            WriteLine("*                                         *");
            WriteLine("* Welcome to Rio's: The Community Library *");
            WriteLine("*                                         *");
            WriteLine("*                                         *");
            WriteLine("***_***_***_***_***_***_***_***_***_***_***");

            WriteLine("\nAre you Borrower (B) or Staff(S)? ");

            WriteLine("Enter B for Borrow or S for Staff or Enter Q for Quit ");
            Write("Please enter your choice: ");

            Borrower b = null;
            Staff s = null;
            while (true)
            {
                string type = ReadLine();
                if (type.Equals("B") || type.Equals("b"))
                {
                    b = getBorrower();
                    break;
                }
                else if (type.Equals("S") || type.Equals("s"))
                {
                    s = getStaff();
                    break;
                }
                else if (type.Equals("Q") || type.Equals("q"))
                {
                    break;
                }
                else
                {
                    WriteLine("Invalid Choice");
                    Write("Enter B / S / Q: ");
                }
            }

            DvdStore store = new DvdStore();

            string[] genreNames = { "Drama", "Adventure", "Family", "Action", "Sci - fi", "Comedy", "Animated", "Thriller", "Other" };
            Genre[] geners = new Genre[genreNames.Length];

            for (int i = 0; i < genreNames.Length; i++)
            {
                Genre g = new Genre(genreNames[i], store);
                geners[i] = g;
            }
            store.setGeners(geners);

            //dramma
            DvD d1 = new DvD("Titanic", "Leo", "Christoper", 240, "Drama", "MA15+", "22/10/1992");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Jerry", "Dona", "Sasha", 160, "Drama", "M15+", "10/07/2000");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Violet", "Siya Bing", "Joshua", 170, "Drama", "G", "12/01/2008");
            store.add(d1);
            store.add(d1);

            //adventure
            d1 = new DvD("Share", "Jereffey", "Emma", 120, "Adventure", "G", "10/03/2003"); //two indentical movies
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Share", "Rudyard", "Wonayi", 120, "Adventure", "M15", "01/11/2004"); //two identical movies
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Ring", "Jane", "Sonnami", 150, "Adventure", "PG", "10/03/2018");
            store.add(d1);
            store.add(d1);

            //family
            d1 = new DvD("Stuart", "Brothers and Co.", "Sara", 120, "Family", "G", "10/02/2003");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Star", "Broyman", "Sia and Co.", 120, "Family", "G", "11/02/2002");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Winner", "Colin", "Roy", 140, "Family", "G", "02/02/2013");
            store.add(d1);
            store.add(d1);


            //action
            d1 = new DvD("Race", "Colin", "Roy", 130, "Action", "PG", "11/01/2003");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Rush", "Chris", "Christoper", 120, "Action", "M15+", "22/04/2015");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Crash", "Harry", "Josh", 200, "Action", "G", "28/03/2000");
            store.add(d1);
            store.add(d1);

            //Sci-fi
            d1 = new DvD("Brain cells", "Dormey", "Claire", 130, "Sci - fi", "G", "21/03/2020");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Moon", "Yasmen", "Cloe", 140, "Sci - fi", "PG", "01/07/1988");
            store.add(d1);
            store.add(d1);

            //comedy
            d1 = new DvD("Grown ups", "Adam", "Derek", 180, "Comedy", "M15+", "22/05/2005");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Hangover", "Bradley Cooper", "Sigma", 190, "Comedy", "MA15+", "24/05/2003");
            store.add(d1);
            store.add(d1);

            //animated
            d1 = new DvD("Bolt", "Jennifer", "Ross", 190, "Animation", "G", "21/11/2006");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Frozen", "Hasan", "Diana", 150, "Animation", "M15+", "11/12/2015");
            store.add(d1);
            store.add(d1);


            //thriller
            d1 = new DvD("The Door", "Hannah", "Emily", 140, "Thriller", "PG", "02/03/2020");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("The Night", "William", "Miles", 160, "Thriller", "MA15+", "03/03/2011");
            store.add(d1);
            store.add(d1);

            //other
            d1 = new DvD("Julius", "Nolan", "Denim Boys", 120, "Other", "G", "11/04/1995");
            store.add(d1);
            store.add(d1);
            d1 = new DvD("Sun and Soon", "Odinson", "Olivers", 170, "Other", "PG", "13/11/2001");
            store.add(d1);
            store.add(d1);


            if (b != null)
            {
                while (true)
                {
                    WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                   // WriteLine("Welcome " + b.firstName);
                    WriteLine("Please select option from Menu to go to next option: ");
                    WriteLine("\nPlease select below Options");
                    WriteLine("A) Search by Genere");
                    WriteLine("B) Search by Title");
                    WriteLine("C) Rent DvD by Title");
                    WriteLine("D) Return DvD by Title");
                    WriteLine("E) List all Titles");
                    WriteLine("Q) Quit");
                    WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Write("Please enter your input: ");
                    string option = ReadLine();
                    WriteLine("------------------------------------------------");
                    if (option.Equals("A") || option.Equals("a"))
                    {
                        WriteLine("Please enter Genre to search (Drama, Adventure, Family, Action, Sci - fi, Comedy, Animated, Thriller, Other):  ");
                        string genre = ReadLine();
                        store.SearchByGenre(genre);

                    }
                    else if (option.Equals("B") || option.Equals("b"))
                    {
                        Write("Please enter Title to search: ");
                        string title = ReadLine();
                        DvD d =store.Search(title);
                        if (d != null)
                        {
                            d.str();
                        }
                        else
                            WriteLine(title + "  not found");
                        
                    }
                    else if (option.Equals("C") || option.Equals("c"))
                    {
                        Write("Please enter Title to rent: ");
                        string title = ReadLine();
                        b.lend(title, store);
                    }
                    else if (option.Equals("D") || option.Equals("d"))
                    {
                        Write("Please enter Title to return: ");
                        string title = ReadLine();
                        b.returnDvD(title, store);
                    }
                    else if (option.Equals("E") || option.Equals("e"))
                    {
                        store.traverse();
                    }
                    else if (option.Equals("Q") || option.Equals("q"))
                    {
                        WriteLine("Thank you for using the system");
                        break;
                    }
                    else
                    {
                        WriteLine("Invalid Option typed by user  [" + option + "]");
                    }
                }
            }

            if (s != null)      
            {
                while (true)
                {
                    WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                   // WriteLine("Welcome " + s.name);
                    WriteLine("Please select option from Menu to for next options ");

                    WriteLine("A) Search by Genere");
                    WriteLine("B) Search by Title");
                    WriteLine("C) Enter DvD by Title");
                    WriteLine("D) Remove entry by Title");
                    WriteLine("E) List all Titles");
                    WriteLine("Q) Quit");
                    WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Write("Please enter your input: ");
                    string option = ReadLine();
                    WriteLine("------------------------------------------------");
                    if (option.Equals("A") || option.Equals("a"))
                    {
                        Write("Please enter Genre to search: ");
                        string genre = ReadLine();
                        store.SearchByGenre(genre);
                    }
                    else if (option.Equals("B") || option.Equals("b"))
                    {
                        Write("Please enter Title to search: ");
                        string title = ReadLine();
                        DvD d =store.Search(title);
                        if (d != null)
                        {
                            d.str();
                        }
                        else
                            WriteLine(title + " not found");
                    }
                    else if (option.Equals("C") || option.Equals("c"))
                    {
                   
                        s.addDVD(store);
                    }
                    else if (option.Equals("D") || option.Equals("d"))
                    {
                      
                        s.rmoveDVD(store);
                    }
                    else if (option.Equals("E") || option.Equals("e"))
                    {
                        store.traverse();
                    }
                    else if (option.Equals("Q") || option.Equals("q"))
                    {
                        WriteLine("Thank you for using the system");
                        break;
                    } else
                    {
                        WriteLine("Invalid Option typed by user  ["+ option + "]");
                    }
                    
                }

            } 
        }
    }


        //linklist
        class DvdStore //to store Dvd
        {
            DvDNode first; //dvd name
            Genre[] geners; //dvd genre

            public void setGeners(Genre[] geners)
            {
                this.geners = geners;
            }

            public void add(string title)
            {
                DvD dvd = addToStore(title);
                if (dvd != null)
                {
                    for (int i = 0; i < geners.Length; i++)
                    {
                        if (String.Equals(geners[i].name, dvd.genre))
                        {
                            geners[i].addMovietoGenre(title);
                        }
                    }
                }

            WriteLine("DVD " + title + " was added successfully");

            }

            public void add(DvD dvd)
            {
                dvd = addToStore(dvd);
                if (dvd != null)
                {
                    for (int i = 0; i < geners.Length; i++)
                    {
                        if (String.Equals(geners[i].name, dvd.genre))
                        {
                            geners[i].addMovietoGenre(dvd.title);
                        }
                    }
                }

            }

            public DvD addToStore(DvD dvd)
            {
                DvDNode dvdNode = new DvDNode(dvd, dvd.title);
                if (first == null)
                {
                   
                    first = dvdNode;

                }
                else
                {
                    DvDNode prev = first;
                    DvDNode node = first;
                    while (node != null)
                    {
                    if (string.Equals(node.title, dvd.title, StringComparison.OrdinalIgnoreCase))
                    {
                       
                        node.value.addDVDQty(1);
                        return null;
                    }
                   
                        prev = node;
                        node = node.next;

                    }

                    prev.next = dvdNode;


                }

                return dvd;
            }

            public DvD addToStore(string dvdName)
            { //add 

                DvD created = null;
                if (first == null)
                {
                  
                    first = createDvD(dvdName);
                    created = first.value;
                }
                else
                {
                    DvDNode prev = first;
                    DvDNode node = first;
                    while (node != null)
                    {
                       
                        if (string.Equals(node.title, dvdName, StringComparison.OrdinalIgnoreCase))
                        {
                           
                            node.value.addDVDQty(1);
                            return created;
                        } 
                    
                    prev = node;
                        node = node.next;

                    }

                   
                    prev.next = createDvD(dvdName);
                    created = prev.next.value;


                }

                return created;
            }

            public bool deleteByGenre(string title)
            {
                DvD dvd = deleteTitle(title);
                if (dvd != null)
                {
                    for (int i = 0; i < geners.Length; i++)
                    {
                        if (String.Equals(geners[i].name, dvd.genre))
                        {
                             geners[i].removeMovietoGenre(title);
                        }
                    }
                WriteLine("DVD " + title + " was removed successfully");
            }
            else
            {
                WriteLine("DVD " + title + " was not found");
            }
           
            return false;
            }

            public DvD deleteTitle(string title)
            {

                DvDNode prev = first;
                DvDNode next = first.next;

                if (first.title.Equals(title)
                          && first.value.recordStore.size == 0)
                {

                    first = first.next;
                    return prev.value;
                }
                else
                {

                    while (next != null)
                    {
                        if (next.title.Equals(title) && next.value.recordStore.size == 0)
                        {
                            DvD d = next.value;
                            prev.next = next.next;
                            return d;
                        }
                        prev = next;
                        next = next.next;
                    }
                }
                return null;


            }


            public DvD Search(string title)
            {
                DvDNode n = first;
                while (n != null)
                {
                    if (string.Equals(n.title, title, StringComparison.OrdinalIgnoreCase))
                    {
                        return n.value;
                    }
                    n = n.next;
                }

                return null;
            }

            public DvD SearchByGenre(string genere)
            { if (genere.Equals("Drama") || genere.Equals("Adventure") || genere.Equals("Family") || genere.Equals("Action") || genere.Equals("Sci - fi") || genere.Equals("Comedy") || genere.Equals("Animated") || genere.Equals("Thriller") || genere.Equals("Other")) 
                        
            {
                for (int i = 0; i < geners.Length; i++)
                {
                   
                    if (String.Equals(geners[i].name, genere))
                    {
                        geners[i].showAll();
                    }
                }
            }
            else
            {
                WriteLine("Invalid " + genere);
                WriteLine("please enter from valid types");
            }
                return null;
            }

            public DvDNode createDvD(string title)
            {
            WriteLine("No  DVD found with title " + title + " Kindly enter the details");
            
            Write("Enter Starring: ");
                string starring = ReadLine();
                Write("Enter Director: ");
                string director = ReadLine();
                Write("Enter Duration: ");
               
                int duration = Convert.ToInt32(ReadLine());
                Write("Enter Genre: ");
                string genre = ReadLine();
                Write("Enter Classification: ");
                string classify = ReadLine();
                Write("Enter Release Date: ");
                string date = ReadLine();
             
            DvD dvd = new DvD(title, starring, director, duration, genre, classify, date);
                DvDNode node = new DvDNode(dvd, title);
                return node;

            }



            public bool action(Record record, bool lend)
            {

                DvDNode node = first;
                bool success = false;
                while (node != null)
                {
                    if (string.Equals(node.title, record.title, StringComparison.OrdinalIgnoreCase))
                    {
                        if (lend)
                        {
                            success = node.value.addRecord(record);

                        }
                        else
                        {
                            success = node.value.removeRecord(record.contactno);
                        }
                    }
                    node = node.next;
                }

                return success;

            }

            public void traverse()
            {

                
                DvDNode node = first;
            WriteLine("Title: " + "---------" + "Available Count: ");
            while (node != null)
                {
                    DvD dvd = node.value;
                    dvd.str2();
                    node = node.next;
                }
            }

        }

        class DvDNode //node for linked list
        {
            public DvDNode next;
            public DvD value;
            public string title;

            public DvDNode(DvD val, string title)
            {
                this.value = val;
                this.title = title;
            }

        }


        class DvD //all info about dvd
        {

            public string title;

            string starring;
            
            string director;
            
            public int duration;
            
            public string genre;
          
            string classify;
           
            string date;

            public int totalDvds;

            public RecordStore recordStore;


            public DvD(string title, string starring, string director, int duration, string genre, string classify, string date) //constructor
            {

                this.title = title;
                this.starring = starring;
                this.director = director;
                this.duration = duration;
                this.genre = genre;
                this.classify = classify;
                this.date = date;
                this.totalDvds = 1;
                this.recordStore = new RecordStore();
            }

            public void addDVDQty(int qty)
            {
                this.totalDvds = this.totalDvds + qty;

            }

            public bool addRecord(Record record)
            {
                if (recordStore.size < totalDvds)
                {
                    recordStore.add(record);
                    return true;
                }
                return false;
            }

            public bool removeRecord(string contactNo)
            {
                if (recordStore.size > 0)
                {
                    recordStore.delete(contactNo);
                    return true;
                }
                return false;
            }


            public void str()
            {
            WriteLine("Title :" + title);
            WriteLine("Available count:  " + (totalDvds - recordStore.size));
            WriteLine("Duration: " + duration);
            WriteLine("Starring: " + starring);
            WriteLine("Director: " + director);
            WriteLine("Movie classification: " + classify);
            WriteLine("Genre: " + genre);

            WriteLine("Total No of " + title + " rented: " + recordStore.size);
                
                recordStore.traverse();
            }


        public void str2()
        {
            WriteLine( title + "    " + (totalDvds - recordStore.size));
        }

        }

        class Borrower //user borrow's
        {
            public string firstName;
            public string lastName;
            public string contactno;
            RecordStore store;

            public Borrower(string firstName, string lastName, string contactno)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.contactno = contactno;
                this.store = new RecordStore();
            }

            public void lend(String title, DvdStore dvdStore)
            {
                Record rec = new Record();
                rec.firstName = firstName;
                rec.lastName = lastName;
                rec.contactno = contactno;
                rec.title = title;
            if (dvdStore.action(rec, true))
            {
                this.store.add(rec);
                WriteLine(title + " DVD was successfully rented");
            }
            else
            {
                WriteLine("Please check "+ title + " exists or all DVD's are rented");
            }
            }

            public void returnDvD(String title, DvdStore dvdStore)
            {
                Record rec = new Record();
                rec.firstName = firstName;
                rec.lastName = lastName;
                rec.contactno = contactno;
                rec.title = title;
                if (this.store.delete(contactno))
                {
                    if(dvdStore.action(rec, false))
                {
                    WriteLine("Thank you for returning " + title);
                }
                }else
            {
                WriteLine("Please check " + title + " exists or if you have rented the DVD");
            }
                
            }
        }

        class Record //borrower's info
        {
            public string firstName;
            public string lastName;
            public string contactno;
            public Record next;
            public string title;

            public void str()
            {
                WriteLine("The movie DVD is rented by " + firstName + " " + lastName + " having contacted details: " + contactno);
            }

        }

        class RecordStore //renting info
        {
            Record first;
            public int size;


            public void add(Record rec)
            {


                if (first == null)
                {
                    first = rec;
                }
                else
                {
                    Record prev = first;
                    Record node = first;
                    while (node != null)
                    {
                        if (node.contactno == rec.contactno)
                        {
                            WriteLine("User cannot lend more than 1 DVD of same title");
                            return;
                        }
                        prev = node;
                        node = node.next;
                    }
                    prev.next = rec;

                }
                size++;
            }


            public bool delete(string contactNo)
            {
                if (first==null)
            {
                return false;
            }
                Record prev = first;
                Record next = first.next;

                if (first.contactno.Equals(contactNo))
                {
                    size--;
                    first = first.next;
                    return true;
                }
                else
                {

                    while (next != null)
                    {
                        if (next.contactno.Equals(contactNo))
                        {
                            prev.next = next.next;
                            size--;
                            return true;
                        }
                        prev = next;
                        next = next.next;
                    }
                }
                return false;

            }

            public void traverse()
            {
                Record rec = first;
                while (rec != null)
                {
                    rec.str();
                    rec = rec.next;
                }
            }
        }


        class Staff // staff functioning
        {
            public string name;

            public Staff(string nme)
            {
                name = nme;
            }


            public void addDVD(DvdStore store)
            {
                Write("Enter Name of DVD you want to add to the rack: ");
                string title = ReadLine();
                store.add(title);
            }


            public void rmoveDVD(DvdStore store)
            {
                Write("Enter Name of DVD you want to delete: ");
                string title = ReadLine();
                store.deleteByGenre(title);
            }
        }


        class Genre 
        {
            public string[] titles;

            public string name;
            public int currentSize;
            DvdStore store;
            public Genre(string name, DvdStore store)
            {
                this.titles = new string[20];
                this.name = name;
                this.store = store;
            }

            public void addMovietoGenre(string tile)
            {


                if (titles.Length <= currentSize)
                {
                    string[] temp = new string[titles.Length + 10];
                    for (int i = 0; i < titles.Length; i++)
                    {
                        temp[i] = titles[i];
                    }

                    titles = temp;
                }

                titles[currentSize] = tile;
                currentSize++;

                sort();
            }

            public bool removeMovietoGenre(string tile)
            {


                int j = 0;
                for (int i = 0; i < currentSize; i++, j++)
                {
                    if (titles[i].Equals(tile))
                    {
                        j++;
                        titles[i] = titles[j];

                    }
                    else
                    {
                        titles[i] = titles[j];
                    }

                }
                currentSize--;

                //sort();
                return true;
            }

            //selection sort
            public void sort()
            {
                for (int i = 0; i < currentSize; i++)
                {
                    string temp = titles[i];
                    int lowest = i;
                    for (int j = i; j < currentSize; j++)
                    {
                        if (String.Compare(titles[j], titles[lowest]) < 0)
                        {
                            lowest = j;
                        }

                    }

                    titles[i] = titles[lowest];
                    titles[lowest] = temp;
                }

            }

            public void showAll()
            {
           
                for (int i = 0; i < currentSize; i++)
                {  
                    DvD node = store.Search(titles[i]);
                    if (node != null)
                {
                    WriteLine("--------------------");
                    node.str();
                    }
                }
            }
        }
  
}
