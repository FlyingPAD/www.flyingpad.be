import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MetricsAComponent } from './metrics-a.component';

describe('MetricsAComponent', () => {
  let component: MetricsAComponent;
  let fixture: ComponentFixture<MetricsAComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MetricsAComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MetricsAComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
