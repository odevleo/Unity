// O Sprite Renderer é o componente responsável por exibir uma imagem na tela
// Usado para renderizar sprites

// Para acessar as informações do sprite renderer no script é preciso declarar uma variável do tipo  SpriteRenderer antes
// ex: private SpriteRenderer sRenderer;

// sRenderer = GetComponent<SpriteRenderer>();

// Para mudar a cor de um objeto, por exemplo
// sRenderer.color = Color.blue;

// ou

// sRenderer.color = new Color(50,50,50)   //rgb

// ou 

// Criar uma variável para a cor e alterar manualmente na Unity
// public Color corSprite;
// sRenderer.color = corSprite;


// Alterar o flip do objeto para virar no eixo x ou y
// sRenderer.flipX = true;
// sRenderer.flipY = true;


// Alterar o material do objeto
// Na Unity, adicione o tipo do material e o coloque no objeto, então crie uma variavel para esse material
// public Material novoMaterial;
// sRenderer.material = novoMaterial;


// Para mudar o modo como a imagem é desenhada na tela
// sRenderer.drawMode = SpriteDrawMode.Tiled;


// Mudar a ordem do layer
// sRenderer.sortingOrder = 10;


// Para desativar ou ativar o componente SpriteRenderer do objeto
// sRenderer.enabled = false;