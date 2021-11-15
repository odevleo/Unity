// O componente transform está presente em todos os objetos
// É responsável por armazenar a posição, rotação e escala dos objetos


// Acessar o nome do objeto
// print(this.gameObject.name); 
// ou
// print(this.name);


// Mudar o nome do objeto
// this.gameObject.name = "Novo nome do objeto";


// Verifica se o objeto está ativado (retorna true ou false)
// print(this.gameObject.activeSelf);


// Comando para ativar ou desativar o objeto via script
// this.gameObject.SetActive(false);    // false para desativar e true para ativar


// Retorna a posição do objeto
// print(transform.position);


// Mudar a posição do objeto
// public Vector3 posicao;               // criar uma variavel do tipo Vector3
// transform.position = posicao;         // dessa forma basta alterar os valores de x,y e z na Unity

// ou

// transform.position = new Vector3(10, 0, 0);   // dessa outra forma não é preciso criar uma variavel


// Para mudar a escala é o mesmo processo
// transform.localScale = new Vector3(2,2,2);    // lembrando que ao mexer com a escala do objeto 
 												 // estamos pegando o valor e multiplicando com as dimensões do asset
												 //	ex: uma imagem com 1280x720 se colocarmos a escala em 2,2,2 seria o dobro de 1280x720 



