function test() {
    var FNRegex = /^[a-zA-Z]{2,}$/.test(FirstName);
    var LNRegex = /[a-zA-Z]{2,}$/.test(LastName);
    var UERegex = /^([0-9A-z]{5,30})(@[0-9A-z]{5,10}).([0-9A-z]{2,3})$/.test(UserEmail);
    var PNRegex = /^(\d{3})-(\d{3})-(\d{4})$/.test(PhoneNumber);
    var UPRegex = /^[A-z0-9]{2,}$/.test(UserPassword);
}