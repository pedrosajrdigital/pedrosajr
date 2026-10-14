/* Eventos do Google Analytics (GA4) do pedrosajr.com.br.
   - click_whatsapp: clique em qualquer link do WhatsApp (wa.me).
   - click_email: clique em qualquer link de e-mail (mailto:).
   - generate_lead: envio do formulário de contato (evento recomendado do GA4 para leads).
   O gtag é carregado no layout (_layouts/default.html). */
(function () {
    function track(name, params) {
        if (typeof window.gtag !== 'function') return;
        params = params || {};
        params.page_path = location.pathname;
        // "beacon" garante o envio mesmo quando a página muda logo em seguida (formulário, wa.me).
        params.transport_type = 'beacon';
        window.gtag('event', name, params);
    }

    document.addEventListener('click', function (e) {
        var t = e.target;
        if (!t || !t.closest) return;
        var wa = t.closest('a[href*="wa.me"]');
        if (wa) { track('click_whatsapp', { link_url: wa.href }); return; }
        var mail = t.closest('a[href^="mailto:"]');
        if (mail) track('click_email', { link_url: mail.getAttribute('href') });
    });

    document.addEventListener('submit', function (e) {
        var f = e.target;
        if (f && f.matches && f.matches('form[action*="formsubmit.co"]')) {
            track('generate_lead', { form_name: 'contato' });
        }
    });
})();
