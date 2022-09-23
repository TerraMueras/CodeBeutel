const options = {
  enableHighAccuracy: true,
  timeout: 5000,
  maximumAge: 0,
};

function success(pos) {
  const crd = pos.coords;
  let currentPos = [crd.latitude, crd.longitude];
  map.setView(currentPos, 16);
  L.tileLayer("https://tile.openstreetmap.org/{z}/{x}/{y}.png", {
    maxZoom: 19,
    attribution: "© OpenStreetMap",
  }).addTo(map);
}

function error(err) {
  alert(`ERROR(${err.code}): ${err.message}`);
}
