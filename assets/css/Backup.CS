.header-container {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 20px 5%;
    
    /* Fundo escuro com 85% de opacidade + efeito de desfoque estilo vidro fosco */
    background-color: rgba(5, 5, 5, 0.85);
    backdrop-filter: blur(10px);
    -webkit-backdrop-filter: blur(10px); /* Garantia de compatibilidade com Safari/iOS */
    
    border-bottom: 1px solid rgba(255, 255, 255, 0.05); /* Linha divisória bem sutil */
    
    /* Fixado no topo */
    position: sticky;
    top: 0;
    z-index: 1000;
}


Estilo 2- 
/* ==========================================================================
   CABEÇALHO E NAVEGAÇÃO 
   ========================================================================== */
   .header-container {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 20px 5%; /* Dá um respiro lateral elegante */
    background-color: #050505; /* Fundo escuro e sólido */
    border-bottom: 1px solid #111;
}
 
.main-nav ul {
    display: flex;
    list-style: none; /* Remove as bolinhas da lista */
    gap: 30px; /* Espaçamento entre os links */
    margin: 0;
    padding: 0;
    align-items: center;
}

.main-nav a {
    color: #E0E0E0; /* Cinza claro para não gritar na tela */
    text-decoration: none; /* Remove o sublinhado padrão */
    font-family: 'Montserrat', 'Jost', sans-serif;
    font-weight: 600;
    font-size: 0.85rem;
    text-transform: uppercase;
    letter-spacing: 1px;
    transition: color 0.3s ease; /* Transição suave no hover */
}

.main-nav a:hover {
    color: #ffffff; /* Fica branco puro ao passar o mouse */
}