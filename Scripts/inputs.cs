// Comandos para conseguir configurar os controles do jogo, seja por teclado, mouse ou controle
// São os Input

// Normalmente os comandos de entrada são feitos no Update
// Ou podemos criar uma função para armazenar as entradas e chamar essa função no Update


// Tipos de Input

// O Input.GetButton("Fire1") é enquanto estiver apertando o botão
// Ex: if(Input.GetButton("Fire1")) 
//		{
//			print("Estou segurando Fire1") 
//		}


// O Input.GetButtonDown("Fire1") funciona quando apertar apenas uma vez o botão
// Ex: if(Input.GetButtonDown("Fire1")) 
//		{
//			print("Apertei Fire1") 
//		}


// O Input.GetButtonUp("Fire1") funciona quando apertar e soltar o botão
// Ex: if(Input.GetButtonUp("Fire1")) 
//		{
//			print("Soltei Fire1") 
//		}



// O comando GetAxis é sensivel ao analógico
// O comando GetAxisRow não é sensível ao analógico, ou seja, se for pro lado temos x=1 ou x=-1