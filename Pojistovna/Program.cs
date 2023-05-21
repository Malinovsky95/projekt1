using Pojistovna;

{
    Databaze databaze = new Databaze();

    int volbaMenu = 0;

        Console.WriteLine("---------------------\n");
        Console.WriteLine("Databáze pojištěných \n");
        Console.WriteLine("---------------------\n");
        Console.WriteLine("Hlavní menu");
        Console.WriteLine("1.Přidat pojištěnce");
        Console.WriteLine("2.Vypsat pojištěné");
        Console.WriteLine("3.Smazat pojištěného");
        Console.WriteLine("4.Vyhledej pojištěnce");
        Console.WriteLine("5.Ukončit aplikaci");

    do
    {
        
        volbaMenu = int.Parse(Console.ReadLine());
    

        switch (volbaMenu)

        {
            case 1:
                databaze.PridatPojistence();
                break;
            case 2:
                databaze.VypisPojistencu();
                break;
           case 3:
                databaze.SmazatPojistence();
                break;
            case 4:
                databaze.NajitPojistence();
                break;
          
        }

    } while(volbaMenu !=5);
    
}