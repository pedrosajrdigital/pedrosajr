# Como funciona o Blog

Este arquivo não é publicado no site (está na lista `exclude` do `_config.yml`) — é só um guia de referência dentro do repositório.

## Estrutura que foi criada

- `_config.yml` — configuração do Jekyll: título do site, URL, permalink padrão dos posts (`/blog/AAAA/MM/DD/titulo/`) e os plugins `jekyll-sitemap` (gera `sitemap.xml`), `jekyll-seo-tag` (gera meta tags/Open Graph de SEO) e `jekyll-feed` (gera `feed.xml`, RSS). Todos são plugins liberados pelo GitHub Pages — não precisa instalar nada.
- `_layouts/post.html` — o layout visual de um artigo individual (título, data, conteúdo, botão de voltar e CTA).
- `blog.html` — listagem dos posts em português (filtra por `lang: pt-BR`).
- `en/blog.html` — listagem dos posts em inglês (filtra por `lang: en`).
- `_posts/` — cada arquivo aqui dentro é um artigo. Já tem dois exemplos: um de boas-vindas em PT e outro em EN.
- Os menus (header e footer) já têm o link "Blog" adicionado, nos dois idiomas.

## Como publicar um novo artigo

1. Dentro de `_posts/`, crie um arquivo novo chamado `AAAA-MM-DD-titulo-curto.md` (a data no nome do arquivo vira a data de publicação — pode ser uma data futura, o post só aparece automaticamente a partir dela).
2. Comece o arquivo com este cabeçalho (front matter):

   ```yaml
   ---
   layout: post
   title: "Título do artigo"
   lang: pt-BR
   author: Paulo Pedrosa Jr.
   excerpt: "Resumo de uma linha que aparece na listagem do blog."
   ---
   ```

3. Escreva o texto normalmente depois do segundo `---`, em Markdown (parágrafos separados por linha em branco, `**negrito**`, `[texto do link](https://...)`, `## Subtítulo`) ou em HTML puro, se preferir mais controle.
4. Dê commit e push como sempre. O GitHub Pages rebuilda o site automaticamente (leva de 1 a 3 minutos).

## Publicando a versão em inglês do mesmo artigo

Crie outro arquivo em `_posts/` com `lang: en` e, importante, adicione esta linha extra no front matter para o post cair em `/en/blog/...` em vez da raiz:

```yaml
permalink: /en/blog/:year/:month/:day/:title/
```

Não existe hoje uma ligação automática "esta página em EN é a tradução desta em PT" — cada um é um post independente. Se no futuro isso importar para SEO, dá pra adicionar um campo `translation_of:` no front matter e usar depois; não implementei porque ainda não temos artigos reais publicados.

## Sobre os artigos que já existem no LinkedIn

Os "Articles" do LinkedIn ficam no domínio deles e o Google praticamente não indexa esse conteúdo. A ideia é: o texto definitivo/canônico passa a viver aqui no blog (que agora tem sitemap + SEO tags automáticos), e o LinkedIn vira só um canal de divulgação — um resumo com link apontando para o artigo completo no blog.

Ao migrar um artigo do LinkedIn, vale reescrever a introdução e o fechamento (não só copiar e colar) para: (a) evitar problema de conteúdo duplicado, e (b) já alinhar o texto ao posicionamento atual ("engenheiro de performance digital", experiência global, aprendizado no mercado brasileiro).
