// Como configurar o fps do jogo

// Antes de tudo, é necessário desligar o Vsync 
// O Vsync se trata da atualização vertical da tela, é mais utilizado para jogos 3D
// Para desligar o Vsync:
// No Start(), digite QualitySettings.vSyncCount = 0;


// Feito isso, o comando para limitar o fps só é preciso utilizar uma única vez no Start()
// O comando: Application.targetFrameRate = 60;  