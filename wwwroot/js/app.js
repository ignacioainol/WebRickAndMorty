document.addEventListener("DOMContentLoaded", () => {
    const getCharacters = async () => {
        const data = await axios.get('https://localhost:7270/test');
        return data;
    }

    getCharacters().then(({ data }) => {
        const { results } = data;
        console.log(results);
        let infoCharacters = "";
        results.map((values) => {
            infoCharacters += `
            <div class="col">
                <div class="card shadow-sm">
                <!--<svg class="bd-placeholder-img card-img-top" width="100%" height="225" xmlns="http://www.w3.org/2000/svg" role="img" aria-label="Placeholder: Thumbnail" preserveAspectRatio="xMidYMid slice" focusable="false"><title>Placeholder</title><rect width="100%" height="100%" fill="#55595c"/><text x="50%" y="50%" fill="#eceeef" dy=".3em">Thumbnail</text></svg>-->
                <img src="${values.image}" alt="">

                <div class="card-body">
                    <p class="card-text">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                    <div class="d-flex justify-content-between align-items-center">
                    <div class="btn-group">
                        <button type="button" class="btn btn-sm btn-outline-secondary">View</button>
                        <button type="button" class="btn btn-sm btn-outline-secondary">Edit</button>
                    </div>
                    <small class="text-muted">9 mins</small>
                    </div>
                </div>
                </div>
            </div>`;
        })

        document.getElementById('containerCharacters').innerHTML = infoCharacters;
    });

});

