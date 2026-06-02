const status_promo = document.getElementById("preco_promocao");
const porc_promo = document.getElementById("preco_desconto");
const valor_promo = document.getElementById("preco_final_promo");
 
 
 
function togglePorcPromo() {
 
  if (status_promo.value === "1") {
    porc_promo.disabled = false;
    porc_promo.required = true;
  } else {
    porc_promo.disabled = true;
    porc_promo.value = ""; // opcional: limpa o campo ao desativar
    valor_promo.value = "";
  }
}

// Chama a função ao carregar a página
togglePorcPromo();
 
// Escuta mudanças no select
status_promo.addEventListener("change", togglePorcPromo);
 
const valor_custo = document.getElementById("preco_custo");
const porc_venda = document.getElementById("preco_lucro");
const valor_venda = document.getElementById("preco_venda");
 
function calculo_venda() {
  let custo = parseFloat(valor_custo.value.replace(",", ".")) || 0;
  let lucro = parseFloat(porc_venda.value.replace("%", "")) || 0;
 
  if (custo != 0) {
    let preco_venda = custo + (custo * lucro) / 100;
   
    valor_venda.value = preco_venda.toFixed(2).replace(".", ",");
  }
  else{
   
    valor_venda.value = "";
  }
}
 
document.getElementById("preco_custo").addEventListener("input", calculo_venda);
document.getElementById("preco_lucro").addEventListener("input", calculo_venda);
 
function calculo_promo() {
  if (status_promo.value === "1") {
    let promo = parseFloat(porc_promo.value.replace("%", "")) || 0;
    let valor = parseFloat(valor_venda.value.replace(",", ".")) || 0;
    let custo = parseFloat(valor_custo.value.replace(",","."));
   
   
    if (promo != 0) {
      let venda_promo = valor - (valor * promo) / 100;
     
      valor_promo.value = venda_promo.toFixed(2).replace(".", ",");
     
      if(venda_promo < custo){
   
        alert("Valor da promoção tem que ser maior que o custo do Produto");
   
        valor_promo.value = "";
        porc_promo.value = "";
   
      }
    } else {
      valor_promo.value = valor_promo.toFixed(2).replace(".", ",");
    }
  } else {
  }
}
document.getElementById("preco_desconto").addEventListener("input", calculo_promo);

calculo_promo();
 calculo_venda();
