app.factory("ajax", function ($http, $q) {
	var resp = undefined;
	return {
		get: function (url, success, error) {
			$http.get(url).then(success, error);
		},
		post: function (url, data, success, error) {
			$http.post(url, data).then(success, error);
		},
	};
});
