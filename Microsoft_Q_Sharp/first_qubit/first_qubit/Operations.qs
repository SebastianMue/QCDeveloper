namespace Quantum.first_qubit
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    
    operation HelloQ () : Unit {
		//Create the new Qubit
        using(qubit = Qubit()) {

			//Measure the state of the qubit
			let status = M(qubit);

			//Print the result to the console
			if(status == Zero) {
				Message("Zero");
			} else {
				Message("One");
			}	
		}
    }
}
