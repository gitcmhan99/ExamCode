using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*-----------------------------------------------------------------------------
 * Name: CheckPoint04
 * DESC: Control, Manager클래스 제작하여 시스템 만들기..
-----------------------------------------------------------------------------*/
namespace CheckPoint04
{
    class Army
    {
        protected int _HP;
        protected int _MP;
        protected int _Speed;
        protected int _Attack;

        public virtual void Run() {
            Console.Write("{0}의 속도로 ", _Speed);
        }

        public virtual void Attack() {
            Console.WriteLine();

            if(this is Healer) {
                Console.Write("[마법 공격력 - {0}]으로 ", _Attack * _MP);
            }
            else {
                Console.Write("[공격력 - {0}]으로 ", _Attack);
            }
        }
    }

    class Barbarian : Army
    {
        public Barbarian() {
            _HP = 100;
            _MP = 0;
            _Speed = 100;
            _Attack = 100;
        }

        public override void Run() {
            base.Run();

            Console.WriteLine("Barbarian 달려갑니다. ");
        }

        public override void Attack() {
            base.Attack();

            Console.WriteLine("Barbarian이 칼로 공격!!! ");
        }
    }

    class Giant : Army
    {
        public Giant() {
            _HP = 200;
            _MP = 0;
            _Speed = 10;
            _Attack = 200;
        }

        public override void Run() {
            base.Run();

            Console.WriteLine("Giant 달려갑니다. ");
        }

        public override void Attack() {
            base.Attack();

            Console.WriteLine("Giant 공격!!! ");
        }
    }

    class Healer : Army
    {
        public Healer() {
            _HP = 50;
            _MP = 100;
            _Speed = 200;
            _Attack = 10;
        }

        public override void Run() {
            base.Run();

            Console.WriteLine("Healer 날아갑니다. ", _Speed);
        }

        public override void Attack() {
            base.Attack();

            Console.WriteLine("Healer 마볍 공격!!! ");
        }
    }

    class UnitControl
    {
        public enum UNIT
        {
            NONE,
            BARBARIAN,
            GIANT,
            HEALER,
        }

        const int MAX = 10;
        Army[] _ArrArmys;
        int indexCount;

        public UnitControl() {
            _ArrArmys = new Army[MAX];
            indexCount = 0;
        }

        public string Menu() {
            Console.WriteLine(" == 유닛 생성 시스템 == ");
            Console.WriteLine("(1)생성  (2)달리기   (3)공격  (0은 나가기)");

            return Console.ReadLine();
        }

        public void CreateUnit() {
            Console.WriteLine(" == 유닛 생성 == ");
            Console.WriteLine("(1)바바리안  (2)자이언츠   (3)힐러  (0: 뒤로가기)");

            UNIT typeUnit = UNIT.NONE;
            string strInput = Console.ReadLine();

            if(indexCount >= MAX) {
                Console.WriteLine(" == 유닛 생성 불가 == (총 유닛: {0})", indexCount);
                Console.WriteLine();
                return;
            }

            if(strInput.Equals("1") || strInput.Equals("2") || strInput.Equals("3"))
                typeUnit = (UNIT)int.Parse(strInput);

            switch(typeUnit) {
                case UNIT.BARBARIAN:
                    _ArrArmys[indexCount] = new Barbarian();
                    break;
                case UNIT.GIANT:
                    _ArrArmys[indexCount] = new Giant();
                    break;
                case UNIT.HEALER:
                    _ArrArmys[indexCount] = new Healer();
                    break;
                case UNIT.NONE:
                    indexCount--;
                    break;
            }

            indexCount++;

            Console.WriteLine(" == 유닛 생성 완료 == (총 유닛: {0})", indexCount);
            Console.WriteLine();
            
        }

        public void UnitRunMenu() {
            Console.WriteLine(" == 유닛 달리기 == ");
            Console.WriteLine("(1)바바리안  (2)자이언츠   (3)힐러  (4)전체달리기  (0: 뒤로가기)");

            UNIT typeUnit = UNIT.NONE;
            string strInput = Console.ReadLine();

            if(strInput.Equals("1") || strInput.Equals("2") || strInput.Equals("3")) {
                typeUnit = (UNIT)int.Parse(strInput);

                UnitRun(typeUnit);
            }
            else if(strInput.Equals("4")) {
                UnitRun();
            }
            else
                Console.Clear();
        }

        public void UnitRun() {
            for(int i = 0; i < indexCount; i++) {
                _ArrArmys[i].Run();
            }
        }

        public void UnitRun(UNIT typeUnit) {
            switch(typeUnit) {
                case UNIT.BARBARIAN:
                    for(int i = 0; i < indexCount; i++) {
                        if(_ArrArmys[i] is Barbarian)
                            _ArrArmys[i].Run();
                    }
                break;
                case UNIT.GIANT:
                    for(int i = 0; i < indexCount; i++) {
                        if(_ArrArmys[i] is Giant)
                            _ArrArmys[i].Run();
                    }
                    break;
                case UNIT.HEALER:
                    for(int i = 0; i < indexCount; i++) {
                        if(_ArrArmys[i] is Healer)
                            _ArrArmys[i].Run();
                    }
                    break;
            }
        }

        public void UnitAttackMenu() {
            Console.WriteLine(" == 유닛 공격 == ");
            Console.WriteLine("(1)바바리안  (2)자이언츠   (3)힐러  (4)전체공격  (0: 뒤로가기)");

            UNIT typeUnit = UNIT.NONE;
            string strInput = Console.ReadLine();

            if(strInput.Equals("1") || strInput.Equals("2") || strInput.Equals("3")) {
                typeUnit = (UNIT)int.Parse(strInput);

                UnitAttack(typeUnit);
            }
            else if(strInput.Equals("4")) {
                UnitAttack();
            }
            else
                Console.Clear();
        }

        public void UnitAttack() {
            for(int i = 0; i < indexCount; i++) {
                _ArrArmys[i].Attack();
            }
        }

        public void UnitAttack(UNIT typeUnit) {
            switch(typeUnit) {
                case UNIT.BARBARIAN:
                    for(int i = 0; i < indexCount; i++) {
                        if(_ArrArmys[i] is Barbarian)
                            _ArrArmys[i].Attack();
                    }
                    break;
                case UNIT.GIANT:
                    for(int i = 0; i < indexCount; i++) {
                        if(_ArrArmys[i] is Giant)
                            _ArrArmys[i].Attack();
                    }
                    break;
                case UNIT.HEALER:
                    for(int i = 0; i < indexCount; i++) {
                        if(_ArrArmys[i] is Healer)
                            _ArrArmys[i].Attack();
                    }
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args) {
            UnitControl control = new UnitControl();
            string choice;
            bool isLoop = true;

            while(isLoop) {
                choice = control.Menu();

                switch(choice) {
                    case "1":
                        control.CreateUnit();
                        break;
                    case "2":
                        control.UnitRunMenu();
                        break;
                    case "3":
                        control.UnitAttackMenu();
                        break;
                    default:
                        isLoop = false;
                        break;
                }
            }
        }
    }
}
