window.loadDashboardCharts = (catLabels, catData, monthLabels, monthData) => {
    try {
        const themeColors = ['#4361ee', '#3f37c9', '#4895ef', '#4cc9f0', '#f72585', '#7209b7'];

        // Destroy existing instances if they exist (to handle Blazor re-renders)
        const ctx1 = document.getElementById("categoryChart");
        const ctx2 = document.getElementById("monthlyChart");

        // Category Chart (Doughnut)
        new Chart(ctx1, {
            type: 'doughnut',
            data: {
                labels: catLabels,
                datasets: [{
                    data: catData,
                    backgroundColor: themeColors,
                    borderWidth: 0,
                    hoverOffset: 15
                }]
            },
            options: {
                maintainAspectRatio: false,
                plugins: {
                    legend: { position: 'bottom', labels: { usePointStyle: true, padding: 20 } },
                    tooltip: { cornerRadius: 10, padding: 12 }
                },
                cutout: '70%'
            }
        });

        // Monthly Chart (Line with Gradient)
        const gradient = ctx2.getContext('2d').createLinearGradient(0, 0, 0, 400);
        gradient.addColorStop(0, 'rgba(67, 97, 238, 0.2)');
        gradient.addColorStop(1, 'rgba(67, 97, 238, 0)');

        new Chart(ctx2, {
            type: 'line',
            data: {
                labels: monthLabels,
                datasets: [{
                    label: 'Spent',
                    data: monthData,
                    borderColor: '#4361ee',
                    backgroundColor: gradient,
                    fill: true,
                    tension: 0.4, // Smooth curves
                    pointRadius: 5,
                    pointBackgroundColor: '#4361ee',
                    borderWidth: 3
                }]
            },
            options: {
                maintainAspectRatio: false,
                plugins: {
                    legend: { display: false },
                    tooltip: { cornerRadius: 10, padding: 12 }
                },
                scales: {
                    y: {
                        beginAtZero: true,
                        grid: { display: true, color: 'rgba(0,0,0,0.03)' },
                        ticks: { callback: (value) => '$' + value }
                    },
                    x: { grid: { display: false } }
                }
            }
        });
    } catch (err) {
        console.error("Chart rendering error:", err);
        throw err;
    }
};