using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SymbolTable
{
    public class Symbol
    {
        private string symbol;
        private int code;
        public Symbol(string symbol,int code)
        {
            this.symbol = symbol;
            this.code = code;
        }
        public string getSymbol()
        {
            return symbol;
        }
        public int getCode()
        {
            return code;
        }
        public int SortBySymbol(string sym1, string sym2)
        {
            return sym1.CompareTo(sym2);
        }
    }

    public class Tetrada {
        private string prehod;
        private string command;
        private string firstOperandPos;
        private string secOperandPos;
        private string result;

        public Tetrada(string prehod,string command, string firstOperandPos, string secOperandPos, string result)
        {
            this.prehod = prehod;
            this.command = command;
            this.firstOperandPos = firstOperandPos;
            this.secOperandPos = secOperandPos;
            this.result = result;
        }
        public string getPrehod()
        {
            return prehod;
        }
        public string getcomand()
        {
            return command;
        }
        public string getFirstOper()
        {
            return firstOperandPos;
        }
        public string getSecOper()
        {
            return secOperandPos;
        }
        public string getResult()
        {
            return result;
        }
        public void setFirstOper(string fOperand)
        {
            firstOperandPos = fOperand;
        }

        public void setPrehod(string sPrehod)
        {
            prehod = sPrehod;
        }
    }

    public class Program
    {
        public static List<Symbol> SymbolTable = new List<Symbol>();
        public static List<Tetrada> Tetrads = new List<Tetrada>();
        public static string gre6ka = "";
        public static int syn_gre6ka = 0;
        public static int synn_gre6ka = 0;
        public static int i = 1;

        public static bool bracket = true;
        public static string bracketRez = "";
        public static string rez = "";
        public static string expRez = "";

        static void Main(string[] args)
        {
            List<int> integ=LexAn();
            if (gre6ka == "Leksi4na gre6ka")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.OutputEncoding = System.Text.UnicodeEncoding.Unicode;
                Console.WriteLine("Лексична грешка !!!");
                Console.WriteLine("Символът на позиция {0} е невалиден", SymbolTable.Count + 1);
                Console.WriteLine("Списъкът до момента на грешката е :");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine("      SYMBOL TABLE");
            Console.WriteLine("==========================");
            Console.WriteLine("pos      symbol      code");
            Console.WriteLine("==========================");
            int pos = 1;
            foreach (Symbol s in SymbolTable)
            {
                Console.WriteLine("{0,-5}    {1,-5}    {2,5}", pos, s.getSymbol(), s.getCode());
                pos++;
            }
            Console.WriteLine();
            Console.WriteLine();
            pos = 1;
            Console.WriteLine("LIST WITH POINTERS");
            Console.WriteLine("====================");
            Console.WriteLine("pos    pointer");
            Console.WriteLine("====================");
            foreach (int pointer in integ)
            {
                Console.WriteLine("{0,-5}  {1,-5}", pos, pointer);
                pos++;
            }
            //-----------------------------za izvejdane na gre6kite-------------
            if(gre6ka == "")
            {
            synn_gre6ka = SyntAn(integ);
            if (synn_gre6ka >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.OutputEncoding = System.Text.UnicodeEncoding.Unicode;
                Console.WriteLine("УСШЕШНО КОМПИЛИРАНЕ!!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
 
                switch (synn_gre6ka)
                {
                    case -1: Console.WriteLine("Забравено е добавянето на program в началото");
                        break;
                    case -2: Console.WriteLine("Забравено е името на програмата");
                        break;
                    case -3: Console.WriteLine("Забравен begin в началото");
                        break;
                    case -4: Console.WriteLine("Забравен end в края");
                        break;
                    case -5: Console.WriteLine("Забравен знак за присвояване");
                        break;
                    case -6: Console.WriteLine("Забравена откриваща скоба на условния опертор");
                        break;
                    case -7: Console.WriteLine("Забравен е знак за сравнение в условния оператор");
                        break;
                    case -8: Console.WriteLine("Забравена закриваща скоба на условния оператор");
                        break;
                    case -9: Console.WriteLine("Забравена откриваща скоба на изпълнимата част на if оператора");
                        break;
                    case -10: Console.WriteLine("Забравена закриваща скоба на изпълнимата част на if оператора");
                        break;
                    case -11: Console.WriteLine("Забравена откриваща скоба на Else оператора");
                        break;
                    case -12: Console.WriteLine("Забравена закриваща скоба на Else оператора");
                        break;
                    case -13: Console.WriteLine("Забравена е отворена скоба");
                        break;
                    case -14: Console.WriteLine("Грешка в израза");
                        break;
                    case -15: Console.WriteLine("Забравена откриваща скоба на While цикъла");
                        break;
                    case -16: Console.WriteLine("Забравен знак за сравнение в While цикъла");
                        break;
                    case -17: Console.WriteLine("Забравена затваряща скоба на While цикъла");
                        break;
                    case -18: Console.WriteLine("Забравена отваряща скоба на изпълнимата част на While цикъла");
                        break;
                    case -19: Console.WriteLine("Забравена затваряща скоба на изпълнимата част на While цикъла");
                        break;
                    case -20: Console.WriteLine("Несъществуващ оператор");
                        break;
                    default:
                        break;
                } 
                Console.ResetColor();
            }
            }

            //---------------------za izvejdane na tetradite -------------------
            int pozicii = 1;   //poziciq na tetradata
            Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5} {4,-5}","pos","COM","OP1","OP2","Rez");
            Console.WriteLine("============================");
            foreach (var tetrad in Tetrads)
            {
                
                int number;
                string fstt = "";
                string sndd = "";
                string re = "";
                if (tetrad.getcomand() == "BRZ" || tetrad.getcomand() == "JMP")
                {
                    fstt = (int.Parse(tetrad.getFirstOper())+1).ToString();   //za da moje poziciite da po4vat ot 1
                    sndd = tetrad.getSecOper();
                    re = tetrad.getResult();
                }

                else
                {

                    if (int.TryParse(tetrad.getFirstOper(), out number))
                    {
                        int fst = int.Parse(tetrad.getFirstOper());
                        fstt = SymbolTable[integ[fst] - 1].getSymbol();
                    }
                    else
                    {
                        fstt = tetrad.getFirstOper();
                    }
                    if (int.TryParse(tetrad.getSecOper(), out number))
                    {
                        int snd = int.Parse(tetrad.getSecOper());
                        sndd = SymbolTable[integ[snd] - 1].getSymbol();
                    }
                    else
                    {
                        sndd = tetrad.getSecOper();
                    }

                    if (int.TryParse(tetrad.getResult(), out number))
                    {
                        int r = int.Parse(tetrad.getResult());
                        re = SymbolTable[integ[r] - 1].getSymbol();
                    }
                    else
                    {
                        re = tetrad.getResult();
                    }
                }
                Console.WriteLine("{0,-5} {1,-5} {2,-5} {3,-5} {4,-5}",pozicii, tetrad.getcomand(), fstt, sndd, re);
                pozicii++;
            }
            //-----------------za zadavane na prehodite--------------------
            int brz = 0;
            int jmp = 0;
            foreach (var tetrad in Tetrads)
            {
                if (tetrad.getcomand() == "BRZ")
                {
                    brz = int.Parse(tetrad.getFirstOper());
                }

                if (tetrad.getcomand() == "JMP")
                {
                    jmp = int.Parse(tetrad.getFirstOper());
                    if (brz < jmp)
                    {
                        if (jmp >= Tetrads.Count) { break; }
                        Tetrads[jmp].setPrehod("true");
                    }
                    else if(brz>jmp)
                    {
                        if (brz >= Tetrads.Count) { break; }
                        Tetrads[brz].setPrehod("true");
                    }
                    else if (brz == jmp)
                    {
                        if (brz >= Tetrads.Count) { break; }
                        Tetrads[brz].setPrehod("true");
                    }
                    jmp = 0;
                    brz = 0;
                }

            }
            ToAsmFile(integ);
        }

        static int FindTab(string symb, int code)
        {
            int bot = 1;
            int mid = 0;
            int top = SymbolTable.Count;
            if (SymbolTable.Count==0)
            {
                SymbolTable.Add(new Symbol(symb, code));
                return 1;
            }
            if (SymbolTable.Count==1)
            {
                if (SymbolTable[0].getSymbol() == symb&&SymbolTable[0].getCode()==code)
                {
                    return 1;
                }
                else
                {
                    SymbolTable.Add(new Symbol(symb, code));
                    return 2;
                }
            }
            else
            {
            List<Symbol> sortTable = SortTable();

            if (sortTable[0].getSymbol() == symb)
            {
                return sortTable[0].getCode() + 1;
            }
            while (bot<=top)
            {
                mid = (bot + top) / 2;
                if (mid==sortTable.Count)
                {
                    SymbolTable.Add(new Symbol(symb, code));
                    return SymbolTable.Count;
                }
                if (StringToCharInt(sortTable[mid].getSymbol()) > StringToCharInt(symb))
                {
                    top = mid - 1;
                }
                else if (StringToCharInt(sortTable[mid].getSymbol()) < StringToCharInt(symb))
                {
                    bot = mid + 1;
                }
                else if (StringToCharInt(sortTable[mid].getSymbol()) == StringToCharInt(symb))
                {
                    if (sortTable[mid].getSymbol() == symb)
                    {
                        return sortTable[mid].getCode() + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            SymbolTable.Add(new Symbol(symb, code));
            return SymbolTable.Count ;
            }
        }

        static List<Symbol> SortTable()
        {
            List<Symbol> sortedmass = new List<Symbol>();
            for (int i = 0; i < SymbolTable.Count; i++)
            {
                sortedmass.Add(new Symbol(SymbolTable[i].getSymbol(), i));
            }
            sortedmass.Sort(delegate(Symbol x, Symbol y)   // sortira lis po char number
            {
                int chX = StringToCharInt(x.getSymbol());
                int chY = StringToCharInt(y.getSymbol());
                return chX.CompareTo(chY);
                
            });
            return sortedmass;
        }

        public static int StringToCharInt(string str)
        {
            char[] mass = str.ToCharArray();
            int charvalue = 0;
            for (int i = 0; i < str.Length; i++)
            {
                charvalue = charvalue + (int)mass[i];
            }
            return charvalue;
        }

        public static List<int> LexAn()
        {
            List<int> ListWithPointer = new List<int>();
            //Console.WriteLine("Vuvedete cod:");
            //string alltext = Console.ReadLine();
            string alltext = Begin();
            string buff = "";
          
            bool notFind = true;
            for (int i = 0; i < alltext.Length; i++)
            {
                if (char.IsLetter(alltext[i]))
                {
                    while (char.IsLetter(alltext[i])||char.IsDigit(alltext[i]))
                    {
                        if (alltext[i]==' ')
                        {
                            break;
                        }
                        buff = buff + alltext[i];
                        i++;
                        if (i == alltext.Length)
                        {
                            break;
                        }
                        
                    }
                    if (buff == "begin" || buff == "BEGIN")
                    {
                        ListWithPointer.Add(FindTab(buff, 20));
                    }
                    else if (buff == "end" || buff == "END")
                    {
                        ListWithPointer.Add(FindTab(buff, 21));
                    }
                    
                    else if (buff == "while" || buff == "WHILE")
                    {
                        ListWithPointer.Add(FindTab(buff, 32));
                    }
                    else if (buff == "if" || buff == "IF")
                    {
                        ListWithPointer.Add(FindTab(buff, 33));
                    }
                    else if (buff == "do" || buff == "DO")
                    {
                        ListWithPointer.Add(FindTab(buff, 34));
                    }
                    
                    else if (buff == "program" || buff == "PROGRAM")
                    {
                        ListWithPointer.Add(FindTab(buff, 35));
                    }

                    else if (buff == "else" || buff == "ELSE")
                    {
                        ListWithPointer.Add(FindTab(buff, 40));
                    }

                    else
                    {
                        ListWithPointer.Add(FindTab(buff, 1));
                    }
                    if (i==alltext.Length)
                    {
                        return ListWithPointer;
                    }
                }
                
                else if (char.IsDigit(alltext[i]))
                {
                    while (char.IsDigit(alltext[i]) && alltext[i] != ' ' && notFind == true)
                    {
                        buff = buff + alltext[i];
                        
                        if (alltext[i]=='.'&&notFind==true)
                        {
                            notFind = false;
                        }
                        else if (alltext[i]=='.'&&notFind==false||char.IsDigit(alltext[i])==false)
                        {
                            gre6ka = "Leksi4na gre6ka";
                            return ListWithPointer;
                        }
                        i++;
                        if (i == alltext.Length)
                        {
                            break;
                        }
                    }
                    ListWithPointer.Add(FindTab(buff, 2));
                    if (i == alltext.Length)
                    {
                        return ListWithPointer;
                    }
                }

                if (alltext[i] == ':')
                {
                    if (alltext[i + 1] == '=')
                    {
                        ListWithPointer.Add(FindTab(":=", 22));
                        i = i + 1;
                        buff = "";
                        continue;
                    }
                    else
                    {
                        ListWithPointer.Add(FindTab(alltext[i].ToString(), 15));
                    }
                }

                if (alltext[i] == '<')
                {
                    if (alltext[i + 1] == '>')
                    {
                        ListWithPointer.Add(FindTab("<>", 30));
                        i = i + 1;
                        buff = "";
                        continue;
                    }
                    else
                    {
                        ListWithPointer.Add(FindTab(alltext[i].ToString(), 18));
                    }
                }

                if (i > alltext.Length-1)
                {
                    break;
                }
                switch (alltext[i])
                    {
                        case '+':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 10));
                            break;
                        case '-':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 11));
                            break;
                        case '=':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 12));
                            break;
                        case '/':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 13));
                            break;
                        case '*':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 14));
                            break;
                        case ';':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 16));
                            break;
                        case '>':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 17));
                            break;
                        case '{':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 36));
                            break;
                        case '}':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 37));
                            break;
                        case '(':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 38));
                            break;
                        case ')':
                            ListWithPointer.Add(FindTab(alltext[i].ToString(), 39));
                            break;
                        case ':':
                            buff = "";
                            continue;
                        case '<':
                            buff = "";
                            continue;
                        case ' ':
                            buff = "";
                            continue;
                        case '\n':
                            buff = "";
                            continue;
                        default:
                            gre6ka = "Leksi4na gre6ka";
                            return ListWithPointer;
                     }
                    buff = "";
            }
            return ListWithPointer;
        }

        public static int SyntAn(List<int> LexAn)
        {
            if (SymbolTable[LexAn[0] - 1].getCode() != 35) { return -1; }
            if (SymbolTable[LexAn[1] - 1].getCode() != 1)
            {
                return -2;
            }
            syn_gre6ka=Start(2, LexAn);
            if (syn_gre6ka < 0)
            {
                return syn_gre6ka;
            }
            else
            {
                return syn_gre6ka; 
            }

        }

        public static int Start(int position, List<int> LexAn)
        {
            if (SymbolTable[LexAn[position] - 1].getCode() != 20)
            {
                return -3;
            }
            position++;
            position = Blok(position,LexAn);
            if (position < 0)
            {
                return position;
            }
            if (SymbolTable[LexAn[position] - 1].getCode() != 21)
            {
                return -4;
            }
            return position;
        }

        public static int Blok(int position, List<int> LexAn)
        {
            position = Operator(position, LexAn);
            if (position < 0)
            {
                return position;
            }
            while (SymbolTable[LexAn[position] - 1].getSymbol()==";")
            {
                if (position == LexAn.Count-1)
                {
                    return position;
                }
                position++;
                position = Operator(position, LexAn);
                if (position < 0)
                {
                    return position;
                }
            }
            return position;
        }

        public static int Operator(int position, List<int> LexAn)
        {
            if (SymbolTable[LexAn[position] - 1].getCode() == 1)    //operatora za prisvoqvane
            {
                string prom = position.ToString();
                position++;
                if (SymbolTable[LexAn[position] - 1].getCode() != 22)
                {
                    return -5;
                }
                position++;
                position=Expression(position, LexAn);
                if (position < 0)
                {
                    return position;
                }
                if (expRez=="")
                {
                    expRez = SymbolTable[LexAn[position - 1] - 1].getSymbol();
                }
                Tetrads.Add(new Tetrada("",":=", expRez, "", prom));
                return position;
            }

            if (SymbolTable[LexAn[position] - 1].getCode() == 33)   //za if operatora
            {
                string symbUslovie = "";
                string operOneUslovie = "";
                string operTwoUslovie = "";
                string operRez = "";
                string BRZ = "";
                int BRZpos = 0;
                string JMP = "";
                int JMPpos = 0;

                position++;
                if(SymbolTable[LexAn[position] - 1].getSymbol() != "(")
                {
                    return -6;
                }
                position++;
                position=Expression(position, LexAn);
                
                operOneUslovie = expRez;
                if (operOneUslovie == "")
                {
                    operOneUslovie = (SymbolTable[LexAn[position-1] - 1].getSymbol());
                }
                if (position < 0)
                {
                    return position;
                }
                if (SymbolTable[LexAn[position] - 1].getCode() != 30 && SymbolTable[LexAn[position] - 1].getSymbol() != "="&&
                    SymbolTable[LexAn[position] - 1].getSymbol() != "<" && SymbolTable[LexAn[position] - 1].getSymbol() !=">")
                {
                    return -7;
                }
                symbUslovie = SymbolTable[LexAn[position] - 1].getSymbol();
                position++;
                position = Expression(position, LexAn);
                operTwoUslovie = expRez;
                if (operTwoUslovie == "")
                {
                    operTwoUslovie = (SymbolTable[LexAn[position - 1] - 1].getSymbol());
                }
                if (position < 0)
                {
                    return position;
                }
                if (SymbolTable[LexAn[position] - 1].getSymbol() != ")")
                {
                    return -8;
                }

                Tetrads.Add(new Tetrada("true",symbUslovie, operOneUslovie, operTwoUslovie, operRez=GegerateString()));
                Tetrads.Add(new Tetrada("","BRZ", "", "", operRez));
                BRZpos = Tetrads.Count - 1;

                position++;
                if (SymbolTable[LexAn[position] - 1].getSymbol() != "{")
                {
                    return -9;
                }
                position++;
                position = Blok(position, LexAn);
                Tetrads.Add(new Tetrada("","JMP", "", "", ""));
                JMPpos = Tetrads.Count - 1;
                BRZ = Tetrads.Count.ToString();
                Tetrads[BRZpos].setFirstOper(BRZ);

                if (position < 0)
                {
                    return position;
                }
                if (SymbolTable[LexAn[position] - 1].getSymbol() != "}")
                {
                    return -10;
                }
                if (position == LexAn.Count - 1)
                {
                    return position;
                }
                position++;

                Tetrads[JMPpos].setFirstOper(BRZ);//tuk moje da grumne


                if (SymbolTable[LexAn[position] - 1].getCode() == 40)  //ako ima else
                {
                    position++;
                    if (SymbolTable[LexAn[position] - 1].getSymbol() != "{")
                    {
                        return -11;
                    }
                    position++;
                    position = Blok(position, LexAn);

                    JMP = Tetrads.Count.ToString();
                    Tetrads[JMPpos].setFirstOper(JMP);
                    if (position < 0)
                    {
                        return position;
                    }
                    if (SymbolTable[LexAn[position] - 1].getSymbol() != "}")
                    {
                        return -12;
                    }
                    position++;
                }
                return position;
            }  //krai na if operatora

            if (SymbolTable[LexAn[position] - 1].getCode() == 32)   //za While cikula
            {
                string symbWhile = "";
                string operOneWhile = "";
                string operTwoWhile = "";
                string operRezz = "";
                string BRZZ = "";
                int BRZZpos = 0;
                string JMPP = "";
                position++;
                if (SymbolTable[LexAn[position] - 1].getSymbol() != "(")
                {
                    return -15;
                }
                position++;
                JMPP = Tetrads.Count.ToString();
                position = Expression(position, LexAn);
                operOneWhile = expRez;
                if (operOneWhile == "")
                {
                    operOneWhile = (SymbolTable[LexAn[position - 1] - 1].getSymbol());
                }
                if (position < 0)
                {
                    return position;
                }
                if (SymbolTable[LexAn[position] - 1].getCode() != 30 && SymbolTable[LexAn[position] - 1].getSymbol() != "=" &&
                    SymbolTable[LexAn[position] - 1].getSymbol() != "<" && SymbolTable[LexAn[position] - 1].getSymbol() != ">")
                {
                    return -16;
                }
                symbWhile = SymbolTable[LexAn[position] - 1].getSymbol();
                position++;
                position = Expression(position, LexAn);
                operTwoWhile = expRez;
                if (operTwoWhile == "")
                {
                    operTwoWhile = (SymbolTable[LexAn[position - 1] - 1].getSymbol());
                }
                if (position < 0)
                {
                    return position;
                }
                if (SymbolTable[LexAn[position] - 1].getSymbol() != ")")
                {
                    return -17;
                }
                position++;


                Tetrads.Add(new Tetrada("true",symbWhile, operOneWhile, operTwoWhile, operRezz = GegerateString()));
                Tetrads.Add(new Tetrada("","BRZ", "", "", operRezz));
                BRZZpos = Tetrads.Count - 1;


                if (SymbolTable[LexAn[position] - 1].getSymbol() != "{")
                {
                    return -18;
                }
                position++;
                position = Blok(position, LexAn);
                Tetrads.Add(new Tetrada("","JMP", JMPP, "", ""));
                BRZZ=Tetrads.Count.ToString();
                Tetrads[BRZZpos].setFirstOper(BRZZ);
                if (position < 0)
                {
                    return position;
                }
                if (SymbolTable[LexAn[position] - 1].getSymbol() != "}")
                {
                    return -19;
                }
                if (position==LexAn.Count-1)
                {
                    return position;
                }
                position++;
                return position;
            }            //krai na While cikula

            return -20;
        }

        public static int Expression(int position, List<int> LexAn)
        {
            position=Term(position,LexAn);
            string operOne = (position-1).ToString();
            string operTwo = "";
            if (position<0)
            {
                return position;
            }
            while (SymbolTable[LexAn[position] - 1].getSymbol() == "+" || SymbolTable[LexAn[position] - 1].getSymbol() == "-")
            {
                string symbSumOrRaz = "";
                if (SymbolTable[LexAn[position] - 1].getSymbol() == "+") { symbSumOrRaz = "+"; }
                else if(SymbolTable[LexAn[position] - 1].getSymbol() == "-") { symbSumOrRaz = "-"; };
                position++;
                position = Term(position, LexAn);
                operTwo = (position-1).ToString();
                if (position < 0)
                {
                    return position;
                }
                if (rez == "")
                {
                    if (bracket == false)
                    {
                        Tetrads.Add(new Tetrada("",symbSumOrRaz, operOne, bracketRez, operOne = GegerateString()));
                        continue;
                    }
                    Tetrads.Add(new Tetrada("",symbSumOrRaz, operOne, operTwo, operOne = GegerateString()));
                    bracketRez = operOne;
                    expRez = operOne;
                }
                else
                {
                    Tetrads.Add(new Tetrada("",symbSumOrRaz, operOne, rez, operOne = GegerateString()));
                    rez = "";
                    expRez = operOne;
                }
            }
            
            return position;
        }

        public static int Term(int position, List<int> LexAn)
        {
            string symbMulOrDiv= "";
            position=Factor(position, LexAn);
            string operOnee = (position - 1).ToString();
            if (position<0)
            {
                return position;
            }
            while (SymbolTable[LexAn[position] - 1].getSymbol() == "*" || SymbolTable[LexAn[position] - 1].getSymbol() == "/")
            {
                if (SymbolTable[LexAn[position] - 1].getSymbol() == "*") { symbMulOrDiv = "*";}
                else if (SymbolTable[LexAn[position] - 1].getSymbol() == "/") { symbMulOrDiv = "/"; }
                position++;
                position=Factor(position, LexAn);
                string operTwoo = (position - 1).ToString();
                if (position < 0)
                {
                    return position;
                }
                if (bracket == false)
                {
                    Tetrads.Add(new Tetrada("",symbMulOrDiv, operOnee, bracketRez, operOnee = GegerateString()));
                    bracket = true;
                    expRez = operOnee;
                    continue;
                }
                Tetrads.Add(new Tetrada("",symbMulOrDiv, operOnee, operTwoo, operOnee = GegerateString()));
                rez = operOnee;
                bracketRez = operOnee;
                expRez = operOnee;
            }
            return position;
        }

        public static int Factor(int position, List<int> LexAn)
        {
            if (SymbolTable[LexAn[position] - 1].getSymbol() == "(")
            {
                bracket = true;
                position++;
                position=Expression(position, LexAn);
                if (position<0)
                {
                    return position;
                }

                if (SymbolTable[LexAn[position] - 1].getSymbol() != ")")
                {
                    return -13;
                }
                position++;
                bracket = false;
                return position;
            }
            else if (SymbolTable[LexAn[position] - 1].getCode() == 1 || SymbolTable[LexAn[position] - 1].getCode() == 2)
                {
                    position++;
                    return position;
                }

            else
                {
                    return -14;
                }
        }

        public static string GegerateString()
        {   
            string temp = "&" + i;
            i++;
            return temp;
        }

        public static void ToAsmFile(List<int> LexAnaliz)
        {
            start(LexAnaliz);
        }

        public static void start(List<int> LexAnaliz)
        {
            for (int i = 0; i < Tetrads.Count; i++)
            {
                if (Tetrads[i].getcomand() == "+" || Tetrads[i].getcomand() == "-" || 
                    Tetrads[i].getcomand() == "/" || Tetrads[i].getcomand() == "*" ||
                    Tetrads[i].getcomand() == ":=")
                {
                    i = AritmeticOper(i,LexAnaliz);
                }

                if (Tetrads[i].getcomand() == "=" || Tetrads[i].getcomand() == "<" ||
                    Tetrads[i].getcomand() == ">" || Tetrads[i].getcomand() == "<>")
                {
                    i = ComparOper(i, LexAnaliz);
                }

                if (Tetrads[i].getcomand() == "BRZ" )
                {
                    i = BRZ(i, LexAnaliz);
                }

                if (Tetrads[i].getcomand() == "JMP")
                {
                    i = JMP(i, LexAnaliz);
                }
            }
        }

        public static int AritmeticOper(int position, List<int> LexAnaliz)
        {
            int numberr;
            string fsttt = "";
            string snddd = "";
            string ree = "";
            if (int.TryParse(Tetrads[position].getFirstOper(), out numberr))
            {
                int fst = int.Parse(Tetrads[position].getFirstOper());
                fsttt = SymbolTable[LexAnaliz[fst] - 1].getSymbol();
            }
            else
            {
                fsttt = Tetrads[position].getFirstOper();
            }
            if (int.TryParse(Tetrads[position].getSecOper(), out numberr))
            {
                int snd = int.Parse(Tetrads[position].getSecOper());
                snddd = SymbolTable[LexAnaliz[snd] - 1].getSymbol();
            }
            else
            {
                snddd = Tetrads[position].getSecOper();
            }

            if (int.TryParse(Tetrads[position].getResult(), out numberr))
            {
                int r = int.Parse(Tetrads[position].getResult());
                ree = SymbolTable[LexAnaliz[r] - 1].getSymbol();
            }
            else
            {
                ree = Tetrads[position].getResult();
            }


            string comand="";
            if (Tetrads[position].getcomand() == "+")
            {
                comand = "ADD";
            }
            if (Tetrads[position].getcomand() == "*")
            {
                comand = "MUL";
            }
            if (Tetrads[position].getcomand() == "-")
            {
                comand = "SUB";
            }
            if (Tetrads[position].getcomand() == "/")
            {
                comand = "DIV";
            }
            if (Tetrads[position].getcomand() == ":=")
            {
                comand = "REZ";
            }
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Ivan\\Desktop\\ASMfile.txt", true))
            {
                if (comand == "REZ")
                {
                    if (Tetrads[position].getPrehod() == "true")
                    {
                        writer.Write("ET{0}  ", position+1);
                    }
                    writer.WriteLine("LDA  {0}", fsttt);
                    writer.WriteLine("STA  {0}", ree);
                }
                else
                {
                    if (Tetrads[position].getPrehod() == "true")
                    {
                        writer.Write("ET{0}  ", position+1);
                    }
                    writer.WriteLine("LDA  {0}", fsttt);
                    writer.WriteLine("{0}  {1}", comand, snddd);
                    writer.WriteLine("STA  {0}", ree);
                }
                writer.WriteLine("============");
            }
            return position;
        }

        public static int ComparOper(int position, List<int> LexAnaliz)
        {
            int numberr;
            string fsttt = "";
            string snddd = "";
            string ree = "";
            if (int.TryParse(Tetrads[position].getFirstOper(), out numberr))
            {
                int fst = int.Parse(Tetrads[position].getFirstOper());
                fsttt = SymbolTable[LexAnaliz[fst] - 1].getSymbol();
            }
            else
            {
                fsttt = Tetrads[position].getFirstOper();
            }
            if (int.TryParse(Tetrads[position].getSecOper(), out numberr))
            {
                int snd = int.Parse(Tetrads[position].getSecOper());
                snddd = SymbolTable[LexAnaliz[snd] - 1].getSymbol();
            }
            else
            {
                snddd = Tetrads[position].getSecOper();
            }

            if (int.TryParse(Tetrads[position].getResult(), out numberr))
            {
                int r = int.Parse(Tetrads[position].getResult());
                ree = SymbolTable[LexAnaliz[r] - 1].getSymbol();
            }
            else
            {
                ree = Tetrads[position].getResult();
            }

            string akum1 = "";
            string akum2 = "";
            string subrez = "";
            if (Tetrads[position].getcomand() == "=")
            {
                akum1 = "#0";
                akum2 = "#1";
                subrez = "BRZ";
            }
            if (Tetrads[position].getcomand() == ">")
            {
                akum1 = "#0";
                akum2 = "#1";
                subrez = "BRP";
            }
            if (Tetrads[position].getcomand() == "<")
            {
                akum1 = "#1";
                akum2 = "#0";
                subrez = "BRP";
            }
            if (Tetrads[position].getcomand() == "<>")
            {
                akum1 = "#1";
                akum2 = "#0";
                subrez = "BRZ";
            }

            using (StreamWriter writer = new StreamWriter("C:\\Users\\Ivan\\Desktop\\ASMfile.txt", true))
            {
                    writer.WriteLine("ET{0}   LDA  {1}",position+1, fsttt);
                    writer.WriteLine("      SUB  {0}", snddd);
                    writer.WriteLine("      {0}  cmp1", subrez);
                    writer.WriteLine("      LDA  {0}", akum1);
                    writer.WriteLine("      JMP  cmp2");
                    writer.WriteLine("cmp1  LDA  {0}", akum2);
                    writer.WriteLine("cmp2  STA  {0}", ree);
                
                    writer.WriteLine("============");
            }
            return position;
        }

        public static int BRZ(int position, List<int> LexAnaliz)
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Ivan\\Desktop\\ASMfile.txt", true))
            {
                writer.WriteLine("LDA  {0}", Tetrads[position].getResult());
                writer.WriteLine("BRZ  ET{0}", (int.Parse(Tetrads[position].getFirstOper())+1).ToString());
                writer.WriteLine("============");
            }
            return position;
        }

        public static int JMP(int position, List<int> LexAnaliz)
        {
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Ivan\\Desktop\\ASMfile.txt", true))
            {
                writer.WriteLine("JMP  ET{0}", (int.Parse(Tetrads[position].getFirstOper()) + 1).ToString());
                writer.WriteLine("============");
            }
            return position;
        }

        public static string Begin()
        {
            Console.WriteLine("              {0} WELCOME TO JST-COMPILER {1}", (char)4, (char)4);
            int choise = 0;
            string ch = "";
            string source = "";
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please select from where you want to get code:");
            Console.WriteLine("1. From file");
            Console.WriteLine("2. I would like to input the code myself");
            Console.WriteLine();
            do
            {
                Console.Write("Enter your choice here: ");
                ch = Console.ReadLine();

            } while (ch !="1" && ch != "2");
            choise = int.Parse(ch); 
            Console.WriteLine();
            Console.WriteLine();
            if (choise == 1)
            {
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    source = sr.ReadToEnd();
                    Console.WriteLine(source);
                }

            }
            if (choise == 2)
            {
                Console.WriteLine("Enter your code: ");
                source = Console.ReadLine();
            }
            return source;
        }
    }
}
