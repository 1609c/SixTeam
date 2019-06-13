function goPreCheck()
{
 Ajax.call('/flow.php?step=checkoutlogin', '', checkoutResponse, 'GET', 'JSON');
}
function checkoutResponse(result)
{
    if (result.error == 1)
    {
     ojologin();
    }else{
		location.href = "/flow.php?step=checkout";
		}
}

