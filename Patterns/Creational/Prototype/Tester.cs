using System;

namespace Patterns.Creational.Prototype
{
    public class Tester
    {
        public Tester()
        {
            // 實作 userA
            var userA = new User()
            {
                Age = 20,
                Name = "Max",
                MemberInfo = new MemberInfo(111111),
            };
            // 針對 userA 進行淺複製出 userB
            User userB = userA.ShallowCopy();

            Console.WriteLine($"Variable's name: {nameof(userA)}");
            DisplayValues(userA);
            Console.WriteLine($"Variable's name: {nameof(userB)} (shallow clone)");
            DisplayValues(userB);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(">>> Change userB info : Age = 22, Name = Tom, MemberInfo.MemberInfoId = 222222");
            userB.Age = 22;
            userB.Name = "Tom";
            userB.MemberInfo.MemberInfoId = 222222;

            Console.WriteLine($"Variable's name: {nameof(userA)}");
            DisplayValues(userA);
            Console.WriteLine($"Variable's name: {nameof(userB)} (shallow clone)");
            DisplayValues(userB);

            Console.WriteLine(@"
>>>> The shallow object influences the origin object.
>>>> Because 'MemberInfo' property is a reference type.
>>>> So, if you wan't that should be use the deep copy to avoid.

            ");

            // 實作 userC
            var userC = new User()
            {
                Age = 20,
                Name = "Bob",
                MemberInfo = new MemberInfo(333333),
            };
            // 針對 userA 進行深複製出 userD
            var userD = userC.DeepCopy();

            Console.WriteLine($"Variable's name: {nameof(userC)}");
            DisplayValues(userC);
            Console.WriteLine($"Variable's name: {nameof(userD)} (deep clone)");
            DisplayValues(userD);

            Console.WriteLine(">>> Change userD info : Age = 40, Name = Tim, MemberInfo.MemberInfoId = 444444");
            userD.Age = 40;
            userD.Name = "Tim";
            userD.MemberInfo.MemberInfoId = 444444;

            Console.WriteLine($"Variable's name: {nameof(userC)}");
            DisplayValues(userC);
            Console.WriteLine($"Variable's name: {nameof(userD)} (shallow clone)");
            DisplayValues(userD);
        }

        public static void DisplayValues(User u)
        {
            Console.WriteLine($"Name: {u.Name}, Age: {u.Age}");
            Console.WriteLine($"Value: {u.MemberInfo.MemberInfoId}");
            Console.WriteLine();
        }
    }

    public class MemberInfo
    {
        public int MemberInfoId;

        public MemberInfo(int MemberInfoId)
        {
            this.MemberInfoId = MemberInfoId;
        }
    }

    public class User
    {
        public int Age;

        public string Name;

        public MemberInfo MemberInfo;

        public User ShallowCopy()
        {
            return (User)this.MemberwiseClone();
        }

        public User DeepCopy()
        {
            User other = (User)this.MemberwiseClone();
            other.MemberInfo = new MemberInfo(MemberInfo.MemberInfoId);
            other.Name = Name.ToString();
            return other;
        }
    }
}