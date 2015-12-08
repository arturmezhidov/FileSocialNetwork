function RegisterViewModel(firstName, lastName, login, pass, confirsmPass, email, phone, groupId) {
	this.FirstName = firstName || '';
	this.LastName = lastName || '';
	this.Login = login || '';
	this.Password = pass || '';
	this.ConfirmPassword = confirsmPass || '';
	this.Email = email || '';
	this.Phone = phone || '';
	this.GroupId = groupId || 0;
}