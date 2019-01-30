#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: Microsoft.Quantum.QsCompiler.Attributes.CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum.first_qubit\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/Startklar/Desktop/QCDeveloper/Code/Microsoft_Q_Sharp/create_new_project/first_qubit/first_qubit/first_qubit/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: Microsoft.Quantum.QsCompiler.Attributes.SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum.first_qubit\",\"Name\":\"HelloQ\"},\"SourceFile\":\"C:/Users/Startklar/Desktop/QCDeveloper/Code/Microsoft_Q_Sharp/create_new_project/first_qubit/first_qubit/first_qubit/Operations.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace Quantum.first_qubit
{
    public class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "Quantum.first_qubit.HelloQ";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            {
#line 7 "C:\\Users\\Startklar\\Desktop\\QCDeveloper\\Code\\Microsoft_Q_Sharp\\create_new_project\\first_qubit\\first_qubit\\first_qubit\\Operations.qs"
                var qubit = Allocate.Apply();
#line 8 "C:\\Users\\Startklar\\Desktop\\QCDeveloper\\Code\\Microsoft_Q_Sharp\\create_new_project\\first_qubit\\first_qubit\\first_qubit\\Operations.qs"
                var status = M.Apply(qubit);
#line 9 "C:\\Users\\Startklar\\Desktop\\QCDeveloper\\Code\\Microsoft_Q_Sharp\\create_new_project\\first_qubit\\first_qubit\\first_qubit\\Operations.qs"
                if ((status == Result.Zero))
                {
#line 10 "C:\\Users\\Startklar\\Desktop\\QCDeveloper\\Code\\Microsoft_Q_Sharp\\create_new_project\\first_qubit\\first_qubit\\first_qubit\\Operations.qs"
                    Message.Apply("Zero");
                }
                else
                {
#line 12 "C:\\Users\\Startklar\\Desktop\\QCDeveloper\\Code\\Microsoft_Q_Sharp\\create_new_project\\first_qubit\\first_qubit\\first_qubit\\Operations.qs"
                    Message.Apply("One");
                }

#line hidden
                Release.Apply(qubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<HelloQ, QVoid, QVoid>(QVoid.Instance);
        }
    }
}