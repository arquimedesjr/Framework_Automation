#language: pt-BR

Funcionalidade: [01]-pesquisa_compra_passagem
	pesquisar compra de passagem 
	para 2 adultos e selecione a 
	menor tarifa do dia. 


Cenario: Pesquisar Passgem
	Dado acesso ao site GOL
	Quando preencho o campo Origem
	E preencho o campo Destino
	E seleciono Data da Ida Dia atual mais um e Data da Volta dois messes após data.
	E clico no botão Compre aqui
	#E clico no campo Melhor Combo da Tarifa Ligth
	Entao Valido os campos do Melhor Combo da Tarifa Ligth
