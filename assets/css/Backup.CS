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
