// Para movimentar objetos podemos usar o transform ou física

// Usando física utilizamos o Rigidbody

// Dessa forma

// private Rigidbody2D rb;
// public float velocidade;

/* void Start() {
		
		rb = GetComponent<Rigidbody2D>();

}
*/


/* void Update () { 

	float x = 1 * velocidade;

	rb.velocity = new Vector2(x,0);
}
*/


// Usando física para movimentação, não precisamos utilizar o comando Time.deltatime

// Utilizamos o Time.deltatime quando trabalhamos com o transform, para garantir que o FPS
// não interfira no desempenho