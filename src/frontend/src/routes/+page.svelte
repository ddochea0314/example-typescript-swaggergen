<script lang="ts">
    import { WeatherApi, type WeatherForecast } from "../lib/weatherApi";
    const { weatherForecast } = new WeatherApi({
        baseUrl : "https://localhost:7032"
    });
    
    let weather : WeatherForecast | undefined = undefined;
    
</script>

<h1>Welcome to SvelteKit</h1>
<p>Visit <a href="https://kit.svelte.dev">kit.svelte.dev</a> to read the documentation</p>

<button on:click={async () => 
    {
        const { data } = await weatherForecast.getWeatherForecastById(1);
        weather = data;
    }  
    }>Click Me
</button>
    
{#if weather}
    <div>
        <h2>{weather.date}</h2>
        <p>{weather.temperatureC}</p>
        <p>{weather.summary}</p>
    </div>
{/if}

<p>
==========================
</p>


{#await weatherForecast.getWeatherForecast()}
    <h2>loading...</h2>
{:then response} 
    {#each response.data as weather }
    <div>
        <h2>{weather.date}</h2>
        <p>{weather.temperatureC}</p>
        <p>{weather.summary}</p>
    </div>
    {/each}
{/await}

