const options = {
  enableHighAccuracy: true,
  timeout: 5000,
  maximumAge: 0,
};

function success(pos) {
  const crd = pos.coords;
  let currentPos = [crd.latitude, crd.longitude];
  map.setView(currentPos, 18)
}

function error(err) {
  alert(`ERROR(${err.code}): ${err.message}`);
}

function zoomToCurrentPosition(){
    navigator.geolocation.getCurrentPosition(success, error, options);
}
